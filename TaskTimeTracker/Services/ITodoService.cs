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
        Task<bool> CreateTodo(CreateTodoDTO createTodoDTO);
    }
}
