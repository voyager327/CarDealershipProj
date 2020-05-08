using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public string TypeOfVehicle { get; set; }
        public int PriceRangeOffered { get; set; }
        public string TypeOfActivityVehicleBeingUsed { get; set; } 
    }
}
