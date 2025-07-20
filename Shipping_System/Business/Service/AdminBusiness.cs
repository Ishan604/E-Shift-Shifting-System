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
    public class AdminBusiness : IAdminBusiness
    {
        private readonly IAdminRepository _adminRepository; // Repository instance to interact with the data layer
        public AdminBusiness(IAdminRepository adminRepository) // Constructor to inject the repository dependency
        {
            _adminRepository = adminRepository;
        }

        public List<AdminModel> GetAdminDetails(int id)
        {
            return _adminRepository.GetAdminDetails(id); // Calls the repository method to get admin details
        }

        public void LoginAdmin(AdminModel admin)
        {
            _adminRepository.LoginAdmin(admin); // Calls the repository method to log in the admin
        }

        public void UpdateAdminDetails(AdminModel admin)
        {
            _adminRepository.UpdateAdminDetails(admin); // Calls the repository method to update admin details
        }
    }
}
