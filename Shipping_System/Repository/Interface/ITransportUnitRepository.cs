using Shipping_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_System.Repository.Interface
{
    public interface ITransportUnitRepository
    {
        List<TransportUnitModel> GetAllTransportUnits(int containerId); // Method to retrieve all transport units

    }
}
