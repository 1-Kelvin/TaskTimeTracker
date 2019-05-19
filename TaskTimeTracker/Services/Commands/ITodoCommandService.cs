using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Commands
{
    public interface ITodoCommandService
    {  
        Task<ViewTodoDTO> SaveTodoData(TodoDTO todo);
        Task<ViewTodoDTO> CreateTodo(TodoDTO createTodoDTO);
        Task<bool> DeleteTodo(int id);
        Task<ViewTodoDTO> AssignTodoToUser(int userId, int todoId);

    }
}
