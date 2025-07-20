using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Models
{
    public class AssignedJobModel
    {
        public int Id { get; set; } // Unique identifier for the assigned job
        public int JobId { get; set; } // Unique identifier for the job
        public int LoadId { get; set; } // Unique identifier for the load
        public int ContainerId { get; set; } // Unique identifier for the container
        public int UnitId { get; set; } // Unique identifier for the transport unit
        public string LoadItems { get; set; } // Description of items in the load
        public string Weight { get; set; } // Weight of the load
        public DateTime AssignedDate { get; set; } // Date when the job was assigned
    }
}
