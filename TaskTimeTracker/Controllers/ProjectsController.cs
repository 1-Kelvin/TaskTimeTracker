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

namespace TaskTimeTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private IProjectService _service;

        public ProjectsController(UserContext context, IProjectService service)
        {
            _service = service;
        }

        // GET: api/Projects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            var list = await _service.GetAll();
            return Ok(list);
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            var project = _service.GetProject(id);
            if (project == null)
                return BadRequest();
            return Ok(project);
        }

        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProject(int id, Project project)
        {
            var proj = await _service.SaveProjectData(id, project);
            if (proj == null)
                return BadRequest();
            return Ok(proj);
        }

        // POST: api/Projects
        [HttpPost]
        public async Task<ActionResult<ViewProjectDTO>> PostProject(CreateProjectDTO projectDTO)
        {
            ViewProjectDTO project = await _service.CreateProject(projectDTO);
            return CreatedAtAction("GetProject", new { id = project.Id }, project);
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProject(int id)
        {
            bool deleted = await _service.DeleteProject(id);
            if (!deleted)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
