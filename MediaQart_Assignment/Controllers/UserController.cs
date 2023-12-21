using MediaQart_Assignment.Data;
using MediaQart_Assignment.Models;
using MediaQart_Assignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace MediaQart_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        private DataContext _dataContext;
        public UserController(IUserService userService, DataContext context)
        {
            _userService = userService;
            _dataContext = context;
        }

        [HttpPost]
        public IActionResult AddUser(UserDTO request)
        {
            var user = _userService.GetUser(request);   
            var message = _userService.ValidateUser(user);
            if(message == "") {
                _dataContext.Users.Add(user);

                _dataContext.SaveChangesAsync();
            }
            return message == "" ? Ok(request) : BadRequest(message);
        }
    }
}
