using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.User
{
    public class UpdateUserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public string Email { get; set; }
      
        public string RoleName { get; set; }
    }
}
