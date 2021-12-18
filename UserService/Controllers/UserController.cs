using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Services;
using JeanStationModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using ServiceStack.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly List<User> Users = new List<User>()
        {
            new User(){Email="vishnu@gmail.com",Password="admin@123"},
            new User(){Email="raj@gmail.com",Password="admin@1234"}
        };
        private readonly IUserService _userService;
        private readonly IConfiguration _config;
        private IConfiguration config;

        public UserController(IUserService userService, IConfiguration _config)
        {
            _userService = userService;
            _config = config;
        }
        //IConfiguration _config;
        //public UserController(IConfiguration config )
        //{
        //    _config = config;
        //}
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Users;
        }

        
        // POST api/<UserController>
        [HttpPost("Register")]
        public void Post([FromBody] User value)
        {
            Users.Add(value);

        }
        [HttpPost("Validate")]
        public string Validate([FromBody] User value)
        {
            if (ValidateLogin(value))
            {
                var token = GenerateToken(value);
                return token.ToString();
            }
            return null;
        }

        // PUT api/<UserController>/5
        [HttpPut("{Email}")]
        public void Put(string Email, [FromBody] User value)
        {
        }
        private bool ValidateLogin(User u)
        {
            if (u == null)
                return false;
            User user = (User)(from us in Users
                              where us.Email.Equals(u.Email) && us.Password==u.Password
                              select us).FirstOrDefault();
            if (user != null)
                return true;
            else
                return false;
        }
        private string GenerateToken(User u)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                    new Claim(JwtRegisteredClaimNames.Email,u.Email),
                    new Claim("Role","Admin"),
                    new Claim("User",u.Email)
                };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Audience"],
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
