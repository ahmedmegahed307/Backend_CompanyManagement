using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract.IEntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;
        public UserService(IUserDal _userDal, IMapper mapper)
        {
            this._userDal = _userDal;
            this._mapper = mapper;
        }

        public void AddUser(AddUserDTO userDTO)
        {
            var addedUser = _mapper.Map<User>(userDTO);
            addedUser.Password = "";

          
            _userDal.Add(addedUser);
        }

        public void DeleteUser(int id)
        {
            var User = _userDal.Get(a => a.Id == id);
            _userDal.Delete(User);
        }

        public List<UserListDTO> GetAllUsers()
        {
            var Users = _userDal.GetAllUsersWithRoles();
            var UserDTOs = _mapper.Map<List<UserListDTO>>(Users);
            return UserDTOs;
        }



        public void UpdateUser(int id, UpdateUserDTO updatedUser)
        {
            var existingUser = _userDal.Get(a => a.Id == id);
            var updateUser = _mapper.Map(updatedUser, existingUser);

            _userDal.Update(updateUser);
        }


    }
}
