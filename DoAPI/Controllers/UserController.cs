using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.DataAccess;
using DoAPI.Models;
using DoAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        

        [HttpPost]
        public async Task<ActionResult<User>> RegisterUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                User added = await _userService.Register(user);
                return added;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
       
        [HttpGet]
        public async Task<ActionResult<User>> Login([FromQuery] string? email, [FromQuery] string? password)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                User added = await _userService.Login(email, password);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("{userId}")]
        [HttpGet]
        public async Task<ActionResult<User>> GetUser(int userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                User added = await _userService.GetUser(userId);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
    }
}