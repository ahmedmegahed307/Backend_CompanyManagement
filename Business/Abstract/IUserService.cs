using Entities.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<UserListDTO> GetAllUsers();
        void AddUser(AddUserDTO UserDTO);
        void DeleteUser(int id);
        void UpdateUser(int id, UpdateUserDTO updatedUser);
    }
}
