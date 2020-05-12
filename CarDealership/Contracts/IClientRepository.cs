﻿using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Contracts
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        Client GetClient(int clientID);
        void CreateClient(Client client);
    }
}
