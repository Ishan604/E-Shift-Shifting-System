using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Repository.Interface
{
    public interface IJobsRepository
    {
        public void AddJob(JobsModel job); // Method to add a new job
        List<JobsModel> GetJobDetails(int id); // Method to get all jobs
        public void UpdateJob(JobsModel job); // Method to update job details
        public string GetJobStatusByCustomerId(int customerId); // Method to get job status by customer ID
        List<JobsModel> GetAllPendingJobs(); // Method to get all pending jobs(for admin use)
        List<JobsModel> GetAllConfirmedJobs(); // Method to get all completed jobs(for admin use)
        public void UpdatePendingJobs(JobsModel job); // Method to update pending jobs(for admin use)
    }
}
