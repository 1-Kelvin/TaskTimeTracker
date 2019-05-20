using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;
using TaskTimeTracker.Services;
using TaskTimeTracker.Services.Commands;
using TaskTimeTracker.Services.Queries;

namespace TaskTimeTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private IProjectCommandService _commandService;
        private IProjectQueryService _queryService;

        public ProjectsController(UserContext context, IProjectCommandService commandService, IProjectQueryService queryService)
        {
            _commandService = commandService;
            _queryService = queryService;
        }

        // GET: api/Projects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewProjectDTO>>> GetProjects()
        {
            var list = await _queryService.GetAll();
            return Ok(list);
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewProjectDTO>> GetProject(int id)
        {
            var project = await _queryService.GetProject(id);
            if (project == null)
                return BadRequest();
            return Ok(project);
        }

        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProject(int id, ProjectDTO project)
        {
            var proj = await _commandService.SaveProjectData(id, project);
            if (proj == null)
                return BadRequest();
            return Ok(proj);
        }

        // POST: api/Projects
        [HttpPost]
        public async Task<ActionResult<ViewProjectDTO>> PostProject(ProjectDTO projectDTO)
        {
            ViewProjectDTO project = await _commandService.CreateProject(projectDTO);
            return CreatedAtAction("GetProject", new { id = project.Id }, project);
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProject(int id)
        {
            bool deleted = await _commandService.DeleteProject(id);
            if (!deleted)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
