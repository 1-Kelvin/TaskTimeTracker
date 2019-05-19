using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile ()
        {
            CreateMap<Project, ProjectDTO>();
            CreateMap<Project, ViewProjectDTO>();
        }
    }
}
