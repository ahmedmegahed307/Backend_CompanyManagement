using Business.Abstract;
using Entities.DTOs.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Settings
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        [Route("users")]
        public List<UserListDTO> GetAllUsers()
        {
            return _userService.GetAllUsers();

        }

        [HttpPost]
        [Route("add")]
        public void AddUser(AddUserDTO UserDTO)
        {
            _userService.AddUser(UserDTO);


        }


        // PUT /api/users/{id}
        [HttpPut("{id}")]

        public IActionResult UpdateUser(int id, UpdateUserDTO updatedUser)
        {
            _userService.UpdateUser(id, updatedUser);
            return Ok();

        }
        [HttpDelete("{id}")]

        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);

        }

    }
}
