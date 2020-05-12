using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Contracts
{

    public interface IRepositoryWrapper
     
    {
        IVehicleRepository Vehicle { get; }
        IClientRepository Client { get; }
        ISellerRepository Seller { get; }

        void Save();
    }
}
