using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    public class TodoService : ITodoService
    {
        readonly UserContext _context = null;
        private IMapper automapper;

        public TodoService(UserContext context)
        {
            _context = context;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Todo, CreateTodoDTO>());
            automapper = config.CreateMapper();
        }

        public async Task<IEnumerable<Todo>> GetAll()
        {
            return await Task.Run<IEnumerable<Todo>>(
                () => _context.Todos.Select(
                    todo => new Todo
                    {
                        Id = todo.Id,
                        Title = todo.Title,
                        Description = todo.Description,
                        ToFinish = todo.ToFinish
                    }));
        }

        public async Task<Todo> GetTodo(int id)
        {
            return await Task.Run<Todo>(
                () => _context.Todos.FirstOrDefault(t => t.Id == id));
        }

        public async Task<bool> SaveTodoData(Todo todo)
        {
            return await Task.Run<bool>( () =>
            {
              Todo td = _context.Todos.FirstOrDefault(t => t.Id == todo.Id);
              if (td != null)
              {
                    td.Title = todo.Title;
                    td.Description = todo.Description;
                    td.ToFinish = todo.ToFinish;
                    td.Finished = todo.Finished;
                    td.UserID = todo.UserID;
                    td.WorkingHours = todo.WorkingHours;
                    _context.SaveChanges();
                    return true;
              }
                return false;
          });
        }

        public Task<bool> CreateTodo(CreateTodoDTO createTodoDTO)
        {
            throw new NotImplementedException();
        }

    }
}
