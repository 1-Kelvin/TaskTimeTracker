using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;

namespace TaskTimeTracker.Services.Queries
{
    public interface IProjectQueryService
    {
        Task<IEnumerable<ViewProjectDTO>> GetAll();
        Task<ViewProjectDTO> GetProject(int id);
    }
}
