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
                User createdUser = _mapper.Map<User>(user);
                createdUser.Active = true;
                createdUser.Created = DateTime.Now;
                _context.Users.Add(createdUser);
                await _context.SaveChangesAsync();
                return _mapper.Map<ViewUserDTO>(createdUser);
            }
            else
                return null;
        }


        public async Task<bool> SaveUserData(int id, UserDTO user)
        {
            User usr = _context.Users.FirstOrDefault(u => u.Id == id);
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
    }
}

