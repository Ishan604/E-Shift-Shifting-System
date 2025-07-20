using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Models
{
    public class ContainerModel
    {
        public int containerId { get; set; }
        public string containerType { get; set; }
        public string containerCapacity { get; set; }
        public string containerStatus { get; set; }
    }
}
