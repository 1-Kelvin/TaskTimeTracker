using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Commands
{
    public class UserCommandService : IUserCommandService
    {
        private readonly UserContext _context = null;
        private IMapper _mapper;

        // context gets injected
        public UserCommandService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<ViewUserDTO> Authenticate(string username, string password)
        {
            var user = await Task.Run(
                () => _context.Users.SingleOrDefault(
                    u => u.Email == username && u.Password == password
                    )
                );

            // user gets returned if he exists - else null
            return _mapper.Map<ViewUserDTO>(user);
        }

        public async Task<ViewUserDTO> RegisterUser(UserDTO user)
        {
            User usr = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            if (usr == null)
            {
                _context.Users.Add(usr);
                await _context.SaveChangesAsync();
                return _mapper.Map<ViewUserDTO>(usr);
            }
            else
                return null;
        }


        public async Task<bool> SaveUserData(UserDTO user)
        {
            User usr = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (usr != null)
            {
                usr.Firstname = user.Firstname;
                usr.Lastname = user.Lastname;
                usr.Password = user.Password;
                usr.Email = user.Email;
                usr.Level = user.Level;
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public async Task<IEnumerable<ViewTodoDTO>> ListAssignedTodos(int id)
        {
            User usr = await _context.Users
                .Include(p => p.Todos)
                .FirstOrDefaultAsync(u => u.Id == id);

            ICollection<ViewTodoDTO> result = new List<ViewTodoDTO>();

            foreach (Todo todo in usr.Todos)
            {
                result.Add(_mapper.Map<ViewTodoDTO>(todo));
            }
            return result;
        }
    }
}

