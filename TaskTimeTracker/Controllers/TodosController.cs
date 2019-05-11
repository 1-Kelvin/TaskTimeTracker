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

namespace TaskTimeTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoService _service;

        public TodosController(ITodoService service)
        {
            _service = service;
        }

     
        [HttpGet]
        public async Task<IEnumerable<Todo>> GetToDos()
        {
            return await _service.GetAll();
        }

        // GET: api/Todos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Todo>> GetTodo(int id)
        {
            //var todo = await _context.ToDos.FindAsync(id);
            var todo = await _service.GetTodo(id);

            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }

        // PUT: api/Todoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodo(int id, Todo todo)
        {
            if (id != todo.Id)
            {
                return BadRequest();
            }

            Todo td = await _service.SaveTodoData(todo);

            if (td != null)
            {
                return Ok(td);
            }

            return NotFound();
        }

        // POST: api/Todos
        [HttpPost]
        public async Task<ActionResult<Todo>> PostTodo(CreateTodoDTO createTodoDTO)
        {

            Todo todo = await _service.CreateTodo(createTodoDTO);
            return CreatedAtAction("GetTodo", new { id = todo.Id }, todo);
        }

        // DELETE: api/Todos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTodo(int id)
        {
            bool deleted = await _service.DeleteTodo(id);
            if (deleted)
            {
                return NoContent();
            }
            return BadRequest();
        }

    }
}
