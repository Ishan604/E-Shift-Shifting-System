using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Business.Interface
{
    public interface IContainerBusiness
    {
        List<ContainerModel> GetContainerDetails(); // Method to get container details
    }
}
