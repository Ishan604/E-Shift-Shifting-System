using Microsoft.Data.SqlClient;
using Shipping_System.Models;
using Shipping_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shipping_System.Forms.CustomerLogin;

namespace Shipping_System.Repository.Service
{
    public class JobsRepository : IJobsRepository
    {
        String connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";
        public void AddJob(JobsModel job)
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            int customerid = customerRepository.GetCustomerIdByEmail(Session.email); // Get customer ID from session email

            string jobStatus = "Pending"; // Default job status
            job.jobstatus = jobStatus; // Set the job status in the job model

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "INSERT INTO Jobs (customer_id, full_name, start_location, destination, job_status, email, contact_number, shifting_items) " +
                            "VALUES (@customerid, @fullName, @startLocation, @destination, @jobStatus, @email, @phoneNumber, @itemDescription)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerid", customerid);
                cmd.Parameters.AddWithValue("@fullName", job.fullName);
                cmd.Parameters.AddWithValue("@startLocation", job.startLocation);
                cmd.Parameters.AddWithValue("@destination", job.destination);
                cmd.Parameters.AddWithValue("@jobStatus", job.jobstatus);
                cmd.Parameters.AddWithValue("@email", job.email);
                cmd.Parameters.AddWithValue("@phoneNumber", job.phoneNumber);
                cmd.Parameters.AddWithValue("@itemDescription", job.itemDescription);
                cmd.ExecuteNonQuery();
            }
        }

        public List<JobsModel> GetAllConfirmedJobs()
        {
            var confirmedJobs = new List<JobsModel>();
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "SELECT job_id, customer_id, full_name, start_location, destination, shifting_items, job_status, email, contact_number FROM Jobs WHERE job_status = 'Confirmed'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var job = new JobsModel
                    {
                        jobId = Convert.ToInt32(reader["job_id"]),
                        customerId = Convert.ToInt32(reader["customer_id"]),
                        fullName = reader["full_name"].ToString(),
                        startLocation = reader["start_location"].ToString(),
                        destination = reader["destination"].ToString(),
                        itemDescription = reader["shifting_items"].ToString(),
                        jobstatus = reader["job_status"].ToString(),
                        email = reader["email"].ToString(),
                        phoneNumber = reader["contact_number"].ToString()
                    };
                    confirmedJobs.Add(job);
                }
            }
            return confirmedJobs;
        }

        public List<JobsModel> GetAllPendingJobs()
        {
            var pendingJobs = new List<JobsModel>();
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "SELECT * FROM Jobs WHERE job_status = 'Pending'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var job = new JobsModel
                    {
                        jobId = Convert.ToInt32(reader["job_id"]),
                        customerId = Convert.ToInt32(reader["customer_id"]),
                        fullName = reader["full_name"].ToString(),
                        startLocation = reader["start_location"].ToString(),
                        destination = reader["destination"].ToString(),
                        jobstatus = reader["job_status"].ToString(),
                        email = reader["email"].ToString(),
                        phoneNumber = reader["contact_number"].ToString(),
                        itemDescription = reader["shifting_items"].ToString()
                    };
                    pendingJobs.Add(job);
                }
            }
            return pendingJobs;
        }

        public List<JobsModel> GetJobDetails(int id)
        {
            var jobDetails = new List<JobsModel>();
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "SELECT * FROM Jobs WHERE customer_id = @customerId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerId", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var job = new JobsModel
                    {
                        jobId = Convert.ToInt32(reader["job_id"]),
                        customerId = Convert.ToInt32(reader["customer_id"]),
                        fullName = reader["full_name"].ToString(),
                        startLocation = reader["start_location"].ToString(),
                        destination = reader["destination"].ToString(),
                        jobstatus = reader["job_status"].ToString(),
                        email = reader["email"].ToString(),
                        phoneNumber = reader["contact_number"].ToString(),
                        itemDescription = reader["shifting_items"].ToString()
                    };
                    jobDetails.Add(job);
                }
            }
            return jobDetails;
        }

        public string GetJobStatusByCustomerId(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "SELECT job_status FROM Jobs WHERE customer_id = @customerId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                var result = cmd.ExecuteScalar();
                return result.ToString(); // Returns the job status 
            }
        }

        public void UpdateJob(JobsModel job)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "UPDATE Jobs SET full_name = @fullName, start_location = @startLocation, destination = @destination, " +
                            "job_status = @jobStatus, email = @email, contact_number = @phoneNumber, shifting_items = @itemDescription " +
                            "WHERE job_id = @jobId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@jobId", job.jobId);
                cmd.Parameters.AddWithValue("@fullName", job.fullName);
                cmd.Parameters.AddWithValue("@startLocation", job.startLocation);
                cmd.Parameters.AddWithValue("@destination", job.destination);
                cmd.Parameters.AddWithValue("@jobStatus", job.jobstatus);
                cmd.Parameters.AddWithValue("@email", job.email);
                cmd.Parameters.AddWithValue("@phoneNumber", job.phoneNumber);
                cmd.Parameters.AddWithValue("@itemDescription", job.itemDescription);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePendingJobs(JobsModel job)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "UPDATE Jobs SET job_status = @jobStatus WHERE job_id = @jobId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@jobId", job.jobId);
                cmd.Parameters.AddWithValue("@jobStatus", job.jobstatus);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
