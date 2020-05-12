using System;
using System.Collections.Generic;
using System.Text;
using CarDealership.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public object Client { get; internal set; }
    }
}
