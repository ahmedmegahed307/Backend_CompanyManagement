using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public int JobNumber { get; set; }
        public string Description { get; set; }
        
        public string Instruction { get; set; }
        public DateTime LoggedDate { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime EstimationDuration { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

      
        public ICollection<Session>? Sessions { get; set; }

        [ForeignKey(nameof(JobType))]
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }

        [ForeignKey(name: nameof(Client))]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey(name: nameof(Engineer))]
        public int EngineerId { get; set; }
        public Engineer Engineer { get; set; }


    }
}
