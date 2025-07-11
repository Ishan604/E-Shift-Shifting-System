using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Business.Interface
{
    public interface ICustomerBusiness
    {
        public void AddStudent(CustomerModel customer);
        public void LoginCustomer(CustomerModel customer);
        public void UpdateCustomer(CustomerModel customer); 
        List<CustomerModel> GetLoggedInCustomerDetails(string email); 
        List<CustomerModel> GetUpdatedCustomerDetails(int id); 
    }
}
