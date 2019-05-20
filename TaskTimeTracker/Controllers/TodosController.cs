using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    public class TodosController : ControllerBase
    {
        private ITodoQueryService _queryService;
        private ITodoCommandService _commandService;

        public TodosController(ITodoQueryService queryService, ITodoCommandService commandService)
        {
            _queryService = queryService;
            _commandService = commandService;
        }

     
        [HttpGet]
        public async Task<IEnumerable<ViewTodoDTO>> GetToDos()
        {
            //return await _service.GetAll();
            return await _queryService.GetAll();
        }

        // GET: api/Todos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Todo>> GetTodo(int id)
        {
            //var todo = await _context.ToDos.FindAsync(id);
            var todo = await _queryService.GetTodo(id);

            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }

        // PUT: api/Todoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodo(int id, TodoDTO todo)
        {
           
            var td = await _commandService.SaveTodoData(id, todo);

            if (td != null)
            {
                return Ok(td);
            }

            return NotFound();
        }

        // POST: api/Todos
        [HttpPost]
        public async Task<ActionResult<Todo>> PostTodo(TodoDTO todoDTO)
        {
            var todo = await _commandService.CreateTodo(todoDTO);
            return CreatedAtAction("GetTodo", new { id = todo.Id }, todo);
        }

        // DELETE: api/Todos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTodo(int id)
        {
            bool deleted = await _commandService.DeleteTodo(id);
            if (deleted)
            {
                return NoContent();
            }
            return BadRequest();
        }

    }
}
