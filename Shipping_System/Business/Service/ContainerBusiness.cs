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
    public class ContainerBusiness : IContainerBusiness
    {
        private readonly IContainerRepository _containerRepository; // Repository interface for container operations
        
        public ContainerBusiness(IContainerRepository containerRepository) // Constructor to inject the repository dependency
        {
            _containerRepository = containerRepository;
        }

        public List<ContainerModel> GetContainerDetails()
        {
            return _containerRepository.GetContainerDetails();
        }
    }
}
