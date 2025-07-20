using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Repository.Interface
{
    public interface ILoadRepository
    {
        public void AddLoad(LoadModel load); // Method to add a new load
        List<LoadModel> GetAllLoads(); // Method to retrieve all loads
    }
}
