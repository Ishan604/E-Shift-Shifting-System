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
    public class LoadRepository : ILoadRepository
    {
        String connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";
        public void AddLoad(LoadModel load)
        {
            using(SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var query = "INSERT INTO Loads (job_id, container_id, load_description, load_weight, status) " +
                            "VALUES (@jobid, @containerid, @loaddescription, @loadweight, @status)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@jobid", load.jobId);
                command.Parameters.AddWithValue("@containerid", load.containerId);
                command.Parameters.AddWithValue("@loaddescription", load.loadDescription);
                command.Parameters.AddWithValue("@loadweight", load.loadWeight);
                command.Parameters.AddWithValue("@status", load.loadStatus);
                command.ExecuteNonQuery();
            }
        }

        public List<LoadModel> GetAllLoads()
        {
            var loads = new List<LoadModel>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var query = "SELECT * FROM Loads";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    var load = new LoadModel
                    {
                        loadId = Convert.ToInt32(reader["load_id"]),
                        jobId = Convert.ToInt32(reader["job_id"]),
                        containerId = Convert.ToInt32(reader["container_id"]),
                        loadDescription = reader["load_description"].ToString(),
                        loadWeight = reader["load_weight"].ToString(),
                        loadStatus = reader["status"].ToString()
                    };
                    loads.Add(load);
                }
            }
            return loads;
        }
    }
}
