﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    interface ITodoService
    {
        Task<IEnumerable<Todo>> GetAll();
        Task<Todo> GetToDo(int id);
        Task<bool> SaveToDoData(Todo toDo);
    }
}
