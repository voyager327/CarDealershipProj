using CarDealership.Contracts;
using CarDealership.Data;

namespace CarDealership
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IVehicleRepository _vehicle;
        private IClientRepository _client;
        private ISellerRepository _seller;
        public IVehicleRepository Vehicle
        {
            get
            {
                if(_vehicle == null)
                {
                    _vehicle = new VehicleRepository(_context);
                }
                return _vehicle;
            }
        }
        public IClientRepository Client
        {
            get
            {
                if(_client == null)
                {
                    _client = new ClientRepository(_context);
                }
                return _client;
            }
        }
        public ISellerRepository Seller
        {
            get
            {
                if(_seller == null)
                {
                    _seller = new SellerRepository(_context);
                }
                return _seller;
            }
        }
         public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }




    }
       
    
}