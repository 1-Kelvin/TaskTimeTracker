using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAll();
        Task<Project> GetProject(int id);
        Task<Project> SaveProjectData(int id, Project project);
    }
}
