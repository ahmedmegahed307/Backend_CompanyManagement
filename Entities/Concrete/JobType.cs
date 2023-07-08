using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class JobType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<JobSubType> JobSubTypes { get; set; }


    }
}
