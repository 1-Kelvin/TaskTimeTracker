using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services.Queries
{
    public class ProjectQueryService : IProjectQueryService
    {
        private readonly UserContext _context;
        private IMapper _mapper;

        public ProjectQueryService(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ViewProjectDTO>> GetAll()
        {
            return await Task.Run<IEnumerable<ViewProjectDTO>>(
                 () => _context.Projects
                 .Select(p => new ViewProjectDTO
                 {
                     Id = p.Id,
                     UserID = p.UserID,
                     Name = p.Name,
                     Description = p.Description,
                     Finished = p.Finished
                 }));
        }

        public async Task<ViewProjectDTO> GetProject(int id)
        {
            var proj = await _context.Projects.FirstOrDefaultAsync(p => p.Id == id);

            if (proj == null)
                return null;

            return _mapper.Map<ViewProjectDTO>(proj);
        }
    }
}
