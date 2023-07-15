using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Client
{
    public class AddClientDTO
    {
 
        public string ClientCode { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string? VatRate { get; set; }
        public string? VatCurrency { get; set; }
        public string? VatValue { get; set; }
        public string? VatNumber { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ClientPortalAccess { get; set; }
    }
}
