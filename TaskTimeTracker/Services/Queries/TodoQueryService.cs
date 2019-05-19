using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Queries
{
    public class TodoQueryService : ITodoQueryService
    {
        readonly UserContext _context;
        private IMapper _mapper;

        public TodoQueryService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ViewTodoDTO>> GetAll()
        {
            return await Task.Run<IEnumerable<ViewTodoDTO>>(
                () => _context.Todos.Select(
                    todo => _mapper.Map<ViewTodoDTO>(todo))); 
        }

        public async Task<ViewTodoDTO> GetTodo(int id)
        {
            return await Task.Run(
                () => _mapper.Map<ViewTodoDTO>(_context.Todos.FirstOrDefault(t => t.Id == id)));
        }

       

        public async Task<IEnumerable<ViewTodoDTO>> GetAllByUserId(int id)
        {
            return await Task.Run<IEnumerable<ViewTodoDTO>>(
                () => _context.Todos
                .Where(t => t.UserID == id)
                .Select(todo => new ViewTodoDTO
                {
                    ProjectId = todo.ProjectID,
                    Title = todo.Title,
                    ToFinish = todo.ToFinish,
                    WorkingHours = todo.WorkingHours,
                    Description = todo.Description,
                    Finished = todo.Finished
                }
                ));
        }

        public async Task<ViewTodoDTO> AssignTodoToUser(int userId, int todoId)
        {
            var user = _context.Users.Find(userId);
            var todo = _context.Todos.Find(todoId);

            if (user == null || todo == null)
                return null;

            todo.UserID = userId;
            await _context.SaveChangesAsync();

            return _mapper.Map<ViewTodoDTO>(todo);
        }
    }
}
