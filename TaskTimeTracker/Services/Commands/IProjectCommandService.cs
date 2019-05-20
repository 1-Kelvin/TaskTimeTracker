using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Commands
{
    public interface IProjectCommandService
    {
        Task<ViewProjectDTO> SaveProjectData(int id, ProjectDTO project);
        Task<ViewProjectDTO> CreateProject(ProjectDTO createProjectDTO);
        Task<bool> DeleteProject(int id);
        Task<IEnumerable<ViewUserDTO>> ListAssignedUsers(int id);
        Task<bool> AssignUserToProject(int projId, int userId);
    }
}
