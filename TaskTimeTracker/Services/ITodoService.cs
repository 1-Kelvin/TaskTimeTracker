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
        Task<Todo> SaveTodoData(Todo todo);
        Task<Todo> CreateTodo(TodoDTO createTodoDTO);
        Task<bool> DeleteTodo(int id);
        Task<IEnumerable<ViewTodoDTO>> GetAllByUserId(int id);
        Task<ViewTodoDTO> AssignTodoToUser(int userId, int todoId);
    }
}
