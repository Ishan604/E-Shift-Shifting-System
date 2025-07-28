using Microsoft.Data.SqlClient;
using Shipping_System.Models;
using Shipping_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Repository.Service
{
    public class AssignedJobRepository : IAssignedJobRepository
    {
        String connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";
        public void AddAssignedJobDetails(AssignedJobModel assignedJob)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var query = "INSERT INTO AssignedJobs (job_id, unit_id, load_id, container_id, load_description, load_weight, assigned_date) " +
                            "VALUES (@JobId, @UnitId, @LoadId, @ContainerId, @LoadItems, @Weight, @AssignedDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobId", assignedJob.JobId);
                command.Parameters.AddWithValue("@UnitId", assignedJob.UnitId);
                command.Parameters.AddWithValue("@LoadId", assignedJob.LoadId);
                command.Parameters.AddWithValue("@ContainerId", assignedJob.ContainerId);
                command.Parameters.AddWithValue("@LoadItems", assignedJob.LoadItems);
                command.Parameters.AddWithValue("@Weight", assignedJob.Weight);
                command.Parameters.AddWithValue("@AssignedDate", assignedJob.AssignedDate);
                command.ExecuteNonQuery();
            }
        }

        public List<AssignedJobModel> GetAssignedJobDetailsByJobId(int jobId)
        {
            List<AssignedJobModel> assignedJobs = new List<AssignedJobModel>();

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var query = "SELECT * FROM AssignedJobs WHERE job_id = @jobid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@jobid", jobId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AssignedJobModel assignedJob = new AssignedJobModel
                    {
                        Id = Convert.ToInt32(reader["assigned_id"]),
                        JobId = Convert.ToInt32(reader["job_id"]),
                        LoadId = Convert.ToInt32(reader["load_id"]),
                        ContainerId = Convert.ToInt32(reader["container_id"]),
                        UnitId = Convert.ToInt32(reader["unit_id"]),
                        LoadItems = reader["load_description"].ToString(),
                        Weight = reader["load_weight"].ToString(),
                        AssignedDate = Convert.ToDateTime(reader["assigned_date"])

                    };
                    assignedJobs.Add(assignedJob);
                }
            }
            return assignedJobs;
        }
    }
}
