using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskTimeTracker.DTOs;
using TaskTimeTracker.Entities;
using TaskTimeTracker.IServices;
using TaskTimeTracker.Services;
using TaskTimeTracker.Services.Commands;
using TaskTimeTracker.Services.Queries;

namespace TaskTimeTracker.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       
        private ITodoCommandService _todoCommandService;
        private ITodoQueryService _todoQueryService;

        private IUserCommandService _userCommandService;
        private IUserQueryService _userQueryService;

        public UsersController(IUserCommandService userCommandService, 
            IUserQueryService userQueryService, 
            ITodoCommandService todoCommandService,
            ITodoQueryService todoQueryService)
        {
            _todoCommandService = todoCommandService;
            _userCommandService = userCommandService;
            _userQueryService = userQueryService;
            _todoQueryService = todoQueryService;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewUserDTO>>> GetUsers()
        {
            var user = await _userQueryService.GetAll();
            return Ok(user);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewUserDTO>> GetUser(int id)
        {
            var user = await _userQueryService.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, UserDTO user)
        {

            if (user.Email != User.Identity.Name) // use the created identity
                return Forbid();

            if (await _userCommandService.SaveUserData(id, user))
                return NoContent();
            else
                return NotFound();
        }
        

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<ViewUserDTO>> PostUser(UserDTO user)
        {
            if (user == null)
                return BadRequest();

            var u = await _userCommandService.RegisterUser(user);
            if (u != null)
                return CreatedAtAction("GetUser", new { id = u.Id }, u);
            else
                return Conflict(); // http status 409
        }


        private bool UserExists(int id)
        {
            //return _context.Users.Any(e => e.Id == id);
            return false;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<ViewUserDTO>> RegisterUser (UserDTO user)
        {
            if (user == null)
                return BadRequest();

            var u = await _userCommandService.RegisterUser(user);
            if (u != null)
                return CreatedAtAction("GetUser", new { id = u.Id }, u);
            else
                return Conflict();
        }
       

        [HttpGet("{id}/assignedTodos")]
        public async Task<ActionResult<IEnumerable<ViewTodoDTO>>> ListAssignedTodos(int id) 
        {
            IEnumerable<ViewTodoDTO> todos = await _userQueryService.ListAssignedTodos(id);
            if (todos == null)
            {
                return BadRequest();
            }
            return Ok(todos);
        }

        [HttpPut("{id}/assignTodo/{todoId}")]
        public async Task<ActionResult<ViewTodoDTO>> assignTodoToUser(int id, int todoId)
        {
            return await _todoCommandService.AssignTodoToUser(id, todoId);            
        }
    }
}
