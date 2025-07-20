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
    internal class TransportUnitRepository : ITransportUnitRepository
    {
        String connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";
        public List<TransportUnitModel> GetAllTransportUnits(int containerId)
        {
            var transportUnits = new List<TransportUnitModel>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var query = "SELECT * FROM TransportUnits WHERE container_id = @containerid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@containerid", containerId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var unit = new TransportUnitModel
                    {
                        transportunitId = Convert.ToInt32(reader["unit_id"]),
                        containerId = Convert.ToInt32(reader["container_id"]),
                        driverId = Convert.ToInt32(reader["driver_id"]),
                        assistantId = Convert.ToInt32(reader["assistant_id"]),
                        vehicleType = reader["vehicle_type"].ToString(),
                        status = reader["status"].ToString()
                    };
                    transportUnits.Add(unit);
                }
            }
            return transportUnits;
        }
    }
}
