using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Business.Interface
{
    public interface IAssignedJobBusiness
    {
        public void AddAssignedJobDetails(AssignedJobModel assignedJob);
    }
}
