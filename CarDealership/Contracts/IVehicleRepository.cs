using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Contracts
{
    public interface IVehicleRepository : IRepositoryBase<Vehicle>
    {
        object FindByCondition();
    }
}