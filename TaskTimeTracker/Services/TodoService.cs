using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        readonly UserContext _context;
        private IMapper _mapper;

        public TodoService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public async Task<Todo> SaveTodoData(Todo todo)
        {
            return await Task.Run<Todo>( () =>
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
                    td.EstimatedHours = todo.EstimatedHours;
                    td.ProjectID = todo.ProjectID;
                    _context.SaveChanges();
                    return td;
              }
                return null;
            });
        }

        public async Task<Todo> CreateTodo(TodoDTO todoDTO)
        {
            return await Task.Run<Todo>(() =>
            {
               Todo todo = _mapper.Map<Todo>(todoDTO);
               var result = _context.Todos.Add(todo);
               _context.SaveChanges();
               return todo;
            });
        }

        public async Task<bool> DeleteTodo(int id)
        {
            Todo todo = _context.Todos.Find(id);

            if (todo == null)
                return false;
            
            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return true;    
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
