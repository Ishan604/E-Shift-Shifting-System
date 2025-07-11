using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Repository.Interface
{
    public interface ICustomerRepository
    {
        public void AddCustomer(CustomerModel customer); // Method to add a new customer
        public void LoginCustomer(CustomerModel customer); // Method to log in a customer
        public void UpdateCustomer(CustomerModel customer); // Method to update customer details
        List<CustomerModel> GetLoggedInCustomerDetails(string email); // Method to get details of the logged-in customer
        List<CustomerModel> GetUpdatedCustomerDetails(int id); // Method to get updated customer details
    }
}
