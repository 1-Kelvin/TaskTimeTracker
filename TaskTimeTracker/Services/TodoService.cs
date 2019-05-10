﻿using AutoMapper;
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

        public async Task<Todo> CreateTodo(CreateTodoDTO createTodoDTO)
        {
            return await Task.Run<Todo>(() =>
            {
               Todo todo = _mapper.Map<Todo>(createTodoDTO);
               var result = _context.Todos.Add(todo);
               _context.SaveChanges();
               return todo;
            });
        }

        public async Task<bool> DeleteTodo(int id)
        {
            return await Task.Run<bool>(() =>
            {
               Todo todo = _context.Todos.Find(id);
               if (todo == null)
               {
                   return false;
               }
               _context.Todos.Remove(todo);
               _context.SaveChanges();
               return true;
            });
        }

        public async Task<IEnumerable<TodoViewDTO>> GetAllByUserId(int id)
        {
            return await Task.Run<IEnumerable<TodoViewDTO>>(
                () => _context.Todos
                .Where(t => t.UserID == id)
                .Select(todo => new TodoViewDTO
                {
                    ProjectID = todo.ProjectID,
                    Title = todo.Title,
                    ToFinish = todo.ToFinish,
                    WorkingHours = todo.WorkingHours,
                    Description = todo.Description,
                    Finished = todo.Finished
                }
                ));
        }
    }
}
