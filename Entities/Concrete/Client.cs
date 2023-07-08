using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string ClientCode { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? VatRate { get; set; }
        public string? VatCurrency { get; set; }
        public string? VatValue { get; set; }
        public string? VatNumber { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ClientPortalAccess { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Job> Jobs { get; set; }

    }
}
