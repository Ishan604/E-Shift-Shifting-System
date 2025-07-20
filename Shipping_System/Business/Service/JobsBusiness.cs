using Shipping_System.Repository.Interface;
using Shipping_System.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shipping_System.Models;

namespace Shipping_System.Business.Service
{
    public class JobsBusiness : IJobBusiness
    {
        private readonly IJobsRepository _jobsRepository;
        
        public JobsBusiness(IJobsRepository jobsRepository) // Constructor to inject the repository dependency
        {
            _jobsRepository = jobsRepository;
        }
        public void AddJob(JobsModel job)
        {
            _jobsRepository.AddJob(job); // Call the repository method to add a job
        }

        public List<JobsModel> GetAllConfirmedJobs()
        {
            return _jobsRepository.GetAllConfirmedJobs(); // Call the repository method to get all confirmed jobs
        }

        public List<JobsModel> GetAllPendingJobs()
        {
            return _jobsRepository.GetAllPendingJobs(); // Call the repository method to get all pending jobs
        }

        public List<JobsModel> GetJobDetails(int id)
        {
            return _jobsRepository.GetJobDetails(id); // Call the repository method to get job details
        }

        public string GetJobStatusByCustomerId(int customerId)
        {
            return _jobsRepository.GetJobStatusByCustomerId(customerId); // Call the repository method to get job status by customer ID
        }

        public void UpdateJob(JobsModel job)
        {
            _jobsRepository.UpdateJob(job); // Call the repository method to update job details
        }

        public void UpdatePendingJobs(JobsModel job)
        {
            _jobsRepository.UpdatePendingJobs(job); // Call the repository method to update pending jobs
        }
    }
}
