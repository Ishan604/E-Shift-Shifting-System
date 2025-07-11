using Microsoft.Data.SqlClient;
using Shipping_System.Forms;
using Shipping_System.Models;
using Shipping_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Repository.Service
{
    public class CustomerRepository : ICustomerRepository // Implementation of the ICustomerRepository interface
    {
        String connectionstring = "Server=DESKTOP-5CVPK75; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";
        public void AddCustomer(CustomerModel customer)
        {
            using(SqlConnection conn  = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "INSERT INTO Customer (first_name, last_name, email, phone_number, address, password) " +
                            "VALUES (@firstname, @Lastname, @email, @phonenumber, @address, @password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstname", customer.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", customer.Lastname);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@phonenumber", customer.Phonenumber);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@password", customer.Password);
                cmd.ExecuteNonQuery();
            }
        }
        public List<CustomerModel> GetLoggedInCustomerDetails(string email)
        {
            var customerdetails = new List<CustomerModel>();
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "SELECT * FROM Customer WHERE email = @email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var customer = new CustomerModel
                    {
                        CustomerId = Convert.ToInt32(reader["customer_id"]),
                        Firstname = reader["first_name"].ToString(),
                        Lastname = reader["last_name"].ToString(),
                        Email = reader["email"].ToString(),
                        Phonenumber = reader["phone_number"].ToString(),
                        Address = reader["address"].ToString(),
                        Password = reader["password"].ToString()
                    };
                    customerdetails.Add(customer);
                }
            }
            return customerdetails;
        }

        public List<CustomerModel> GetUpdatedCustomerDetails(int id)
        {
            var customerdetails = new List<CustomerModel>();
            using(SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "SELECT * FROM Customer WHERE customer_id = @id";
                SqlCommand cmd= new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    var customer = new CustomerModel
                    {
                        CustomerId = Convert.ToInt32(reader["customer_id"]),
                        Firstname = reader["first_name"].ToString(),
                        Lastname = reader["last_name"].ToString(),
                        Email = reader["email"].ToString(),
                        Phonenumber = reader["phone_number"].ToString(),
                        Address = reader["address"].ToString(),
                        Password = reader["password"].ToString()
                    };
                    customerdetails.Add(customer);
                }
            }
            return customerdetails; 
        }

        public void LoginCustomer(CustomerModel customer)
        {
            using(SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "SELECT * FROM Customer WHERE email = @Email AND password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Password", customer.Password);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login successful!","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information); // Display a message box on successful login
                }
                else
                {
                    MessageBox.Show("Login failed! Please check your email and password.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error); // Display a message box on failed login
                }


            }
        }

        public void UpdateCustomer(CustomerModel customer)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "UPDATE Customer SET first_name = @firstname, last_name = @Lastname, email = @email, phone_number = @phonenumber, address = @address, password = @password WHERE customer_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn); 
                cmd.Parameters.AddWithValue("@id", customer.CustomerId);
                cmd.Parameters.AddWithValue("@firstname", customer.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", customer.Lastname);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@phonenumber", customer.Phonenumber);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@password", customer.Password);
                cmd.ExecuteNonQuery();
            }    
        }
    }
}
