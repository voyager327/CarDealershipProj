using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string SearchForVehicleUsageType { get; set; } //Is it for work, business, pleasure, hobby, or a combination? 
        public double SearchByPriceRangeOption { get; set; } 
        public int SearchByGasMileage { get; set; } 
        public string SearchByCondition { get; set; }
        public string SearchByVehicleHistory { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }



    }
}
