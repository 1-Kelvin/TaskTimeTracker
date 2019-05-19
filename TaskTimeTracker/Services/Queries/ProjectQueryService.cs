using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Queries
{
    public class ProjectQueryService : IProjectQueryService
    {
        private readonly UserContext _context;
        private IMapper _mapper;

        public ProjectQueryService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ViewProjectDTO>> GetAll()
        {
            return await Task.Run<IEnumerable<ViewProjectDTO>>(
                 () => _context.Projects
                 .Select(p => new ViewProjectDTO
                 {
                     Id = p.Id,
                     UserID = p.UserID,
                     Name = p.Name,
                     Description = p.Description,
                     Finished = p.Finished
                 }));
        }

        public async Task<ViewProjectDTO> GetProject(int id)
        {
            var proj = await _context.Users.FirstOrDefaultAsync(p => p.Id == id);

            if (proj == null)
                return null;

            return _mapper.Map<ViewProjectDTO>(proj);
        }

        public async Task<ViewProjectDTO> SaveProjectData(int id, Project project)
        {
            //throw new NotImplementedException();
            return await Task.Run(
                () =>
                {
                    Project proj = _context.Projects.FirstOrDefault(p => p.Id == id);
                    if (proj == null)
                        return null;

                    proj.Name = project.Name;
                    proj.Description = project.Description;
                    proj.ProjectUsers = project.ProjectUsers;
                    proj.Todos = project.Todos;
                    proj.Finished = project.Finished;
                    return _mapper.Map<ViewProjectDTO>(proj);
                });
        }

        public async Task<ViewProjectDTO> CreateProject(ProjectDTO createProjectDTO)
        {
            return await Task.Run(() =>
            {
                Project project = _mapper.Map<Project>(createProjectDTO);
                _context.Projects.Add(project);
                _context.SaveChanges();

                return _mapper.Map<ViewProjectDTO>(project);
            });
        }

        public async Task<bool> DeleteProject(int id)
        {
            return await Task.Run<bool>(() =>
            {
                var project = _context.Projects.Find(id);
                if (project == null)
                    return false;

                _context.Projects.Remove(project);
                _context.SaveChanges();
                return true;
            });
        }
    }
}
