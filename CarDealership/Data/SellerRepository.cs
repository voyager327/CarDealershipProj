using CarDealership.Contracts;
using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Data
{
    public class SellerRepository : RepositoryBase<Seller>, ISellerRepository
    {
        public SellerRepository(ApplicationDbContext applicationDbContext) 
            :base(applicationDbContext)
        {

        }

        public void CreateSeller(Seller seller)
        {
            throw new NotImplementedException();
        }

        public Seller GetSeller(int sellerId)
        {
            throw new NotImplementedException();
        }
        public Seller GetClient(int sellerId) =>
            FindByCondition(c => c.SellerId.Equals(sellerId)).SingleOrDefault();

        public void CreateClient(Seller seller) => Create(seller );
    }  
        
    
}
