using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Commands
{
    public interface IUserCommandService
    {
        Task<ViewUserDTO> Authenticate(string username, string password);
        Task<ViewUserDTO> RegisterUser(UserDTO user);
        Task<bool> SaveUserData(int id, UserDTO user);
    }
}
