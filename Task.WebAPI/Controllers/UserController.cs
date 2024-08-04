using Microsoft.AspNetCore.Mvc;
using Task.Common.DTOs;
using Task.Service.Interfaces;
using Task.WebAPI.Models;
using Tasl.Repository.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            string name = _httpContextAccessor.HttpContext?.User?.Identity?.Name ?? "null";
            //  string name = _httpContextAccessor.HttpContext.User.Identity.Name;
            Console.WriteLine(name);
            return await _userService.GetAllAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<UserDTO> Put(int id, [FromBody] UserModel model)
        {
           return await _userService.UpdateAsync(new UserDTO { UserId=id, Name=model.Name, Family=model.Family});
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
