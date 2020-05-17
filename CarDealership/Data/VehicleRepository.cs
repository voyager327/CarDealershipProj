using CarDealership.Contracts;
using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Data
{
     public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {

        }

        public object FindByCondition()
        {
            throw new NotImplementedException();
        }

    }
}
