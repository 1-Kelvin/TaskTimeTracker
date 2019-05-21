
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Commands
{
    public class ProjectCommandService : IProjectCommandService
    {
        private readonly UserContext _context;
        private IMapper _mapper;

        public ProjectCommandService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ViewProjectDTO> SaveProjectData(int id, ProjectDTO project)
        {
            //throw new NotImplementedException();
            
            Project proj = _context.Projects.FirstOrDefault(p => p.Id == id);
            if (proj == null)
                return null;

            proj = _mapper.Map(project, proj); // _mapper.Map<ProjectDTO, Project>
            await _context.SaveChangesAsync();
            return _mapper.Map<ViewProjectDTO>(proj);
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

        public async Task<IEnumerable<ViewUserDTO>> ListAssignedUsers(int id)
        {
            Project proj = await _context.Projects
                .Include(p => p.ProjectUsers)
                .ThenInclude(pu => pu.User)
                .FirstOrDefaultAsync(p => p.Id == id);

            ICollection<ViewUserDTO> result = new List<ViewUserDTO>();

            foreach (ProjectUser pu in proj.ProjectUsers)
            {
                result.Add(_mapper.Map<ViewUserDTO>(pu.User));
            }
            return result;
        }

        public async Task<bool> AssignUserToProject(int projId, int userId)
        {
            var projusr = _context.ProjectUsers.FirstOrDefault(pu => pu.ProjectId == projId && pu.UserId == userId);
            if (projusr != null)
                return false;

            ProjectUser projectUser = new ProjectUser();
            projectUser.ProjectId = projId;
            projectUser.UserId = userId;
            _context.ProjectUsers.Add(projectUser);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

