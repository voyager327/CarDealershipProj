using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Contracts
{
    public interface ISellerRepository : IRepositoryBase<Seller>

    {
        Seller GetSeller(int sellerId);
        void CreateSeller(Seller seller);
    }
}
