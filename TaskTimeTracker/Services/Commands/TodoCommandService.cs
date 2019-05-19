using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Commands
{
    public class TodoCommandService : ITodoCommandService
    {
        readonly UserContext _context;
        private IMapper _mapper;

        public TodoCommandService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ViewTodoDTO> SaveTodoData(TodoDTO todo)
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
                await _context.SaveChangesAsync();
                return _mapper.Map<ViewTodoDTO>(td);
            }
            return null;
        }

        public async Task<ViewTodoDTO> CreateTodo(TodoDTO createTodoDTO)
        {
            Todo todo = _mapper.Map<Todo>(createTodoDTO);
            var result = _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
            return _mapper.Map<ViewTodoDTO>(todo);
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
