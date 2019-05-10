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

namespace TaskTimeTracker.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITodoService _todoService;

        public UsersController(IUserService service, ITodoService todoService)
        {
            _userService = service;
            _todoService = todoService;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var user = await _userService.GetAll();
            return Ok(user);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _userService.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {

            if (id != user.Id)
                return BadRequest();

            if (user.Email != User.Identity.Name) // use the created identity
                return Forbid();

            if (await _userService.SaveUserData(user))
                return NoContent();
            else
                return NotFound();
        }
        

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            if (user == null)
                return BadRequest();

            var u = await _userService.RegisterUser(user);
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
        public async Task<ActionResult<User>> RegisterUser (User user)
        {
            if (user == null)
                return BadRequest();

            var u = await _userService.RegisterUser(user);
            if (u != null)
                return CreatedAtAction("GetUser", new { id = u.Id }, u);
            else
                return Conflict();
        }

       

        [HttpGet("{id}/assignedTodos")]
        public async Task<ActionResult<IEnumerable<TodoViewDTO>>> ListAssignedTodos(int id) 
        {
            IEnumerable<TodoViewDTO> todos = await _todoService.GetAllByUserId(id);
            if (todos == null)
            {
                return BadRequest();
            }
            return Ok(todos);
        }
    }
}
