using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace EmployeeAdminPortal.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ApplicationDbContext dbContext;

        public UsersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(dbContext.Users.ToList());
        }

        [HttpPost]
        public IActionResult AddUser(addUserDto addUserDto)
        {
            var user = new User()
            {
                Username = addUserDto.Username,
                PasswordHash = Encryptor.HashSHA256(addUserDto.PasswordHash),
                Role = addUserDto.Role
            };
            if (dbContext.Users.Any(u => u.Username == addUserDto.Username))
                return BadRequest("Username already exists");
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return Ok(user);
        }

    }
}
