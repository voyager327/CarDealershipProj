using CarDealership.Contracts;
using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Data
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository

    {
        public ClientRepository(ApplicationDbContext applicationDbContext) 
            :base(applicationDbContext)
        {

        }

        public Client GetClient(int clientId) =>
            FindByCondition(c => c.ClientId.Equals(clientId)).SingleOrDefault();

        public void CreateClient(Client client) => Create(client);
                
    }
}
