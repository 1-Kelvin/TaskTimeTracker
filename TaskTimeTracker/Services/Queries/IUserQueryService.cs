using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;

namespace TaskTimeTracker.Services.Queries
{
    public interface IUserQueryService
    {
        Task<IEnumerable<ViewUserDTO>> GetAll();
        Task<ViewUserDTO> GetUser(int id);
    }
}
