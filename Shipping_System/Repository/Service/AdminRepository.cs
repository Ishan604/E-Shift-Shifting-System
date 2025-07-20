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
    public class AdminRepository : IAdminRepository
    {
        String connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";

        public List<AdminModel> GetAdminDetails(int id)
        {
            var adminList = new List<AdminModel>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var query = "SELECT * FROM Admins WHERE admin_id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var admin = new AdminModel
                    {
                        Id = Convert.ToInt32(reader["admin_id"]),
                        Firstname = reader["first_name"].ToString(),
                        Lastname = reader["last_name"].ToString(),
                        Email = reader["email"].ToString(),
                        Phonenumber = reader["phone_number"].ToString(),
                        Password = reader["password"].ToString()
                    };
                    adminList.Add(admin);
                }
            }
            return adminList;
        }

        public void LoginAdmin(AdminModel admin)
        {
            using(SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var query = "SELECT * FROM Admins WHERE email = @email AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", admin.Email);
                command.Parameters.AddWithValue("@password", admin.Password);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Assuming AdminModel has properties for Firstname, Lastname, Email, and Password
                        admin.Firstname = reader["first_name"].ToString();
                        admin.Lastname = reader["last_name"].ToString();
                        admin.Email = reader["email"].ToString();
                        admin.Password = reader["password"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateAdminDetails(AdminModel admin)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var query = "UPDATE Admins SET first_name = @firstname, last_name = @lastname, email = @email, phone_number = @phonenumber, password = @password WHERE admin_id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstname", admin.Firstname);
                command.Parameters.AddWithValue("@lastname", admin.Lastname);
                command.Parameters.AddWithValue("@email", admin.Email);
                command.Parameters.AddWithValue("@phonenumber", admin.Phonenumber);
                command.Parameters.AddWithValue("@password", admin.Password);
                command.Parameters.AddWithValue("@id", admin.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
