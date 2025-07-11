using Shipping_System.Business.Interface;
using Shipping_System.Models;
using Shipping_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Business.Service
{
    public class CustomerBusiness : ICustomerBusiness 
    {
        private readonly ICustomerRepository _customerRepository; // Repository instance to interact with the data layer

        public CustomerBusiness(ICustomerRepository customerRepository) // Constructor to inject the repository dependency
        {
            _customerRepository = customerRepository;
        }
        public void AddStudent(CustomerModel customer)
        {
            _customerRepository.AddCustomer(customer); // Calls the repository method to add a customer
        }

        public List<CustomerModel> GetLoggedInCustomerDetails(string email)
        {
            return _customerRepository.GetLoggedInCustomerDetails(email); // Calls the repository method to get logged-in customer details
        }

        public List<CustomerModel> GetUpdatedCustomerDetails(int id)
        {
            return _customerRepository.GetUpdatedCustomerDetails(id); // Calls the repository method to get updated customer details
        }

        public void LoginCustomer(CustomerModel customer)
        {
            _customerRepository.LoginCustomer(customer); // Calls the repository method to log in a customer
        }

        public void UpdateCustomer(CustomerModel customer)
        {
            _customerRepository.UpdateCustomer(customer); // Calls the repository method to update customer details
        }
    }
}
