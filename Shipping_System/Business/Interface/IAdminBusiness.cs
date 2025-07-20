using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Business.Interface
{
    public interface IAdminBusiness
    {
        public void LoginAdmin(AdminModel admin); // Method to log in an admin
        List<AdminModel> GetAdminDetails(int id); //Method to get admin details
        public void UpdateAdminDetails(AdminModel admin); // Method to update admin details


    }
}
