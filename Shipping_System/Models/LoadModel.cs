using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Models
{
    public class LoadModel
    {
        public int loadId { get; set; }
        public int jobId { get; set; }
        public int containerId { get; set; }
        public string loadDescription { get; set; }
        public string loadWeight { get; set; }
        public string loadStatus { get; set; }

    }
}
