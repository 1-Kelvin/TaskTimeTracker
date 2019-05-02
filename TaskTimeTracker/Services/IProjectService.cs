using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    interface IProjectService
    {
        Task<IEnumerable<Project>> GetAll();
        Task<Project> GetProject(long id);
        Task<bool> SaveProjectData(Project project);
    }
}
