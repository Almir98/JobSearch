using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JobSearch.WebAPI.Interface;
using JobSearch.WebAPI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace JobSearch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        protected readonly IUserRepository _service;
        private readonly IConfiguration _config;

        public UserController(IUserRepository service, IConfiguration config)
        {
            _service = service;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody] UserVM newUser)
        {
            if (_service.UserExist(newUser.Email))
                return BadRequest("User already exists");

            var user = new UserVM
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Phone = newUser.Phone,
                Email = newUser.Email,
                Adress = newUser.Adress,
                YearOfBirth = newUser.YearOfBirth.Value,
                CityId = newUser.CityId,
                GenderId = newUser.GenderId,
                UserTypeId = newUser.UserTypeId,
                Password = newUser.Password
            };
            var createdUser = _service.Register(user, newUser.Password);
            return StatusCode(201);
        }

        [HttpGet("id")]
        public Model.Users GetUser(int id)
        {
            return _service.GetUser(id);
        }

        [HttpPut("{id}")]
        public Model.Users Update(int id,UserUpsertVM user)
        {
            return _service.Update(id, user);
        }

        //JSON WEB TOKEN 
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(UserLoginVM user)
        {
            var userservice = _service.Login(user.Email.ToLower(), user.Password);
            if (userservice == null)
            {
                return Unauthorized();
            }
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,userservice.UserId.ToString()),
                new Claim(ClaimTypes.Name,userservice.Email)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_config.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }
    }
}