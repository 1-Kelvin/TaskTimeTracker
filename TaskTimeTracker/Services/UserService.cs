using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.Entities;
using TaskTimeTracker.IServices;

namespace TaskTimeTracker.Services
{
    public class UserService : IUserService
    {
        readonly UserContext _context = null;

        // context gets injected
        public UserService(UserContext context)
        {
            _context = context;
        }


        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(
                () => _context.Users.SingleOrDefault(
                    u => u.Email == username && u.Password == password
                    )
                );

            // user gets returned if he exists - else null
            return user;
        }


        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.Run<IEnumerable<User>>(
                () => _context.Users
                .Include(u => u.ToDos)
                .Include(u => u.ProjectUsers)
                .Select(u => new User
                {
                    Id = u.Id,
                    Email = u.Email,
                    Firstname = u.Firstname,
                    Lastname = u.Lastname,
                    Created = u.Created,
                    ProjectUsers = u.ProjectUsers,
                    ToDos = u.ToDos
                }));
        }


        public async Task<User> GetUser(int id)
        {
            return await Task.Run<User>(
                () => _context.Users
                .Include(u => u.ToDos)
                .Include(u => u.ProjectUsers)
                .FirstOrDefaultAsync(u => u.Id == id));
        }

        public async Task<User> RegisterUser(User user)
        {
            User usr = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            if (usr == null)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return user;
            }
            else
                return null;
        }


        public async Task<bool> SaveUserData(User user)
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
    }
}
