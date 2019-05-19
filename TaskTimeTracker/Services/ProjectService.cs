using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    public class ProjectService : IProjectService
    {
        private readonly UserContext _context;
        private IMapper _mapper;

        public ProjectService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetProject(int id)
        {
            return await Task.Run(
                () => _context.Projects
                .Include(pr => pr.Todos)
                .Include(pr => pr.ProjectUsers)
                .FirstOrDefault<Project>(pr => pr.Id == id)
                );
        }

        public async Task<Project> SaveProjectData(int id, Project project)
        {
            //throw new NotImplementedException();
            return await Task.Run<Project>(
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
                    return proj;
                });
        }

        public async Task<ViewProjectDTO> CreateProject(ProjectDTO createProjectDTO)
        {
            return await Task.Run( () =>
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
