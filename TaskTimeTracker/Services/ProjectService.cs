using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    public class ProjectService : IProjectService
    {
        readonly UserContext _context = null;

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await Task.Run<IEnumerable<Project>>(
                () => _context.Projects.Select(project => new Project
                {
                    Id = project.Id,
                    Name = project.Name,
                    Description = project.Description,
                    UserID = project.UserID,
                    Finished = project.Finished,
                    ProjectUsers = project.ProjectUsers,
                    Todos = project.Todos
                }));
        }

        public async Task<Project> GetProject(long id)
        {
            return await Task.Run<Project>(
                () => _context.Projects
                .Include(pr => pr.Todos)
                .Include(pr => pr.ProjectUsers)
                .FirstOrDefault<Project>(pr => pr.Id == id)
                );
        }

        public Task<Project> SaveProjectData(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
