using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using WebApplication5.Repositories.Interfaces;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userRepository.GetUsers();
            return Ok(users);
        }

        
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            _userRepository.AddUser(user);

            return Ok("The user was added!");
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            User user = _userRepository.GetUser(id);

            if (user == null)
            {
                return NoContent();
            }

            return Ok(user);
        }
    }
}
