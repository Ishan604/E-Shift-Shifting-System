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
    public class ContainerRepository : IContainerRepository
    {
        String connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";

        public List<ContainerModel> GetContainerDetails()
        {
            var containerList = new List<ContainerModel>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string query = "SELECT * FROM Containers"; 
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var container = new ContainerModel
                    {
                        containerId = Convert.ToInt32(reader["container_id"]),
                        containerType = reader["container_type"].ToString(),
                        containerCapacity = reader["container_capacity"].ToString(),
                        containerStatus = reader["status"].ToString()
                    };
                    containerList.Add(container);
                }
            }
            return containerList;
        }
    }
}
