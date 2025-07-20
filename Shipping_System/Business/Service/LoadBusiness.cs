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
    public class LoadBusiness : ILoadBusiness
    {
        private readonly ILoadRepository _loadRepository; // Repository interface for load operations
        public LoadBusiness(ILoadRepository loadRepository) // Constructor to inject the repository dependency
        {
            _loadRepository = loadRepository;
        }
        public void AddLoad(LoadModel load)
        {
            _loadRepository.AddLoad(load); // Calls the repository method to add a new load
        }

        public List<LoadModel> GetAllLoads()
        {
            return _loadRepository.GetAllLoads(); // Calls the repository method to retrieve all loads
        }
    }
}
