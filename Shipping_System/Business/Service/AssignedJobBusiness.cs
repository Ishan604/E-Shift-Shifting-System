using Shipping_System.Business.Interface;
using Shipping_System.Models;
using Shipping_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Business.Service
{
    public class AssignedJobBusiness : IAssignedJobBusiness
    {
        private readonly IAssignedJobRepository _assignedJobRepository;
        public AssignedJobBusiness(IAssignedJobRepository assignedJobRepository)
        {
            _assignedJobRepository = assignedJobRepository;
        }
        public void AddAssignedJobDetails(AssignedJobModel assignedJob)
        {
            _assignedJobRepository.AddAssignedJobDetails(assignedJob);
        }

        public List<AssignedJobModel> GetAssignedJobDetailsByJobId(int jobId)
        {
            return _assignedJobRepository.GetAssignedJobDetailsByJobId(jobId);
        }
    }
}
