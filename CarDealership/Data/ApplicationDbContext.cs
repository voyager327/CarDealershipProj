using System;
using System.Collections.Generic;
using System.Text;
using CarDealership.Models;
using Microsoft.AspNetCore.Identity;
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                   new IdentityRole
                   {
                       Name = "Admin",
                       NormalizedName = "ADMIN"
                   }
                   );


        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public object Client { get; internal set; }
    }
}
