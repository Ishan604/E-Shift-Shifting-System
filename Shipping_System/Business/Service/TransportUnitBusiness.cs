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
    public class TransportUnitBusiness : ITransportUnitBusiness
    {
        private readonly ITransportUnitRepository _transportUnitRepository; // Repository interface for transport unit operations
        public TransportUnitBusiness(ITransportUnitRepository transportUnitRepository) // Constructor to inject the repository dependency
        {
            _transportUnitRepository = transportUnitRepository;
        }
        public List<TransportUnitModel> GetAllTransportUnits(int containerId)
        {
            return _transportUnitRepository.GetAllTransportUnits(containerId); // Calls the repository method to retrieve all transport units
        }
    }
}
