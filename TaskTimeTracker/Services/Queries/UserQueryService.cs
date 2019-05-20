using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Queries
{
    public class UserQueryService : IUserQueryService
    {
        private readonly UserContext _context = null;
        private IMapper _mapper;

        // context gets injected
        public UserQueryService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ViewUserDTO>> GetAll()
        {
            return await Task.Run<IEnumerable<ViewUserDTO>>(
                () => _context.Users
                .Select(u => new ViewUserDTO
                {
                    Id = u.Id,
                    Email = u.Email,
                    Firstname = u.Firstname,
                    Lastname = u.Lastname,
                    Created = u.Created,
                    Active = u.Active
                }));
        }


        public async Task<ViewUserDTO> GetUser(int id)
        {
            var user = await Task.Run<User>(
                () => _context.Users
                .Include(u => u.Todos)
                .Include(u => u.ProjectUsers)
                .FirstOrDefaultAsync(u => u.Id == id));
            return _mapper.Map<ViewUserDTO>(user);
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
