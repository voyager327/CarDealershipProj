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
                 

        
    }  
        
    
}
