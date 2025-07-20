using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Models
{
    public class TransportUnitModel
    {
        public int transportunitId { get; set; } // Unique identifier for the transport unit
        public int containerId { get; set; } // Identifier for the container associated with the transport unit
        public int driverId { get; set; } // Identifier for the driver assigned to the transport unit
        public int assistantId { get; set; } // Identifier for the assistant assigned to the transport unit
        public string vehicleType { get; set; } // Type of vehicle used for transportation 
        public string status { get; set; } // Current status of the transport unit 
    }
}
