using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Profiles
{
    public class TodoProfile : Profile
    {
        public TodoProfile()
        {
            CreateMap<Todo, TodoDTO>();
            CreateMap<Todo, ViewTodoDTO>();
            CreateMap<TodoDTO, Todo>();
            CreateMap<ViewTodoDTO, Todo>();
        }
    }
}
