using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Models
{
    public class JobsModel
    {
        public int jobId { get; set; }
        public int customerId { get; set; }
        public string fullName { get; set; }
        public string startLocation { get; set; }
        public string destination { get; set; }
        public string jobstatus { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string itemDescription { get; set; }

    }
}
