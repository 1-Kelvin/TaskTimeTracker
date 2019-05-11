﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    public class ProjectService : IProjectService
    {
        readonly UserContext _context = null;

        public ProjectService(UserContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetProject(int id)
        {
            return await Task.Run<Project>(
                () => _context.Projects
                .Include(pr => pr.Todos)
                .Include(pr => pr.ProjectUsers)
                .FirstOrDefault<Project>(pr => pr.Id == id)
                );
        }

        public async Task<Project> SaveProjectData(int id, Project project)
        {
            //throw new NotImplementedException();
            return await Task.Run<Project>(
                () =>
                {
                    Project proj = _context.Projects.FirstOrDefault(p => p.Id == id);
                    if (proj == null)
                        return null;

                    proj.Name = project.Name;
                    proj.Description = project.Description;
                    proj.ProjectUsers = project.ProjectUsers;
                    proj.Todos = project.Todos;
                    proj.Finished = project.Finished;
                    return proj;
                });
        }

        public async Task<Project> CreateProject(CreateProjectDTO createProjectDTO)
        {
            return await Task.Run<Project>
        }
    }
}
