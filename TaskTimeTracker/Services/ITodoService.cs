using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<Todo>> GetAll();
        Task<Todo> GetTodo(int id);
        Task<bool> SaveTodoData(Todo todo);
        Task<Todo> CreateTodo(CreateTodoDTO createTodoDTO);
        Task<bool> DeleteTodo(int id);
        Task<IEnumerable<TodoViewDTO>> GetAllByUserId(int id);
    }
}
