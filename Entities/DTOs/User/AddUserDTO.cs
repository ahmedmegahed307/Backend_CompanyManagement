using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.User
{
    public class AddUserDTO
    {
     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? RoleId { get; set; }
        public string? RoleName { get; set; }

    }
}
