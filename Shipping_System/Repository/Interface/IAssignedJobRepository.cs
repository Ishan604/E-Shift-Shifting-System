using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Repository.Interface
{
    public interface IAssignedJobRepository
    {
        public void AddAssignedJobDetails(AssignedJobModel assignedJob); //Method to add assigned job details
        List<AssignedJobModel> GetAssignedJobDetailsByJobId(int jobId); // Method to get assigned job details by job ID
    }
}
