using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;

namespace TaskTimeTracker.Services.Queries
{
    public interface ITodoQueryService
    {
        Task<IEnumerable<ViewTodoDTO>> GetAll();
        Task<ViewTodoDTO> GetTodo(int id);
        Task<IEnumerable<ViewTodoDTO>> GetAllByUserId(int id);
    }
}
