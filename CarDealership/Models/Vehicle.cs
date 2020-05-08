using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Vehicle
    {
        [key]
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Price { get; set; }
        public string VehicleCondition { get; set; } 
        public string VehicleUsageActivity { get; set; } //For work, business, pleasure, or a combination? These options could be possibly be broken down into different activities, if we need to.
        public int VehicleMileage { get; set; } 
        public string VehicleHistory { get; set; } //Repairs, Modifications, Accidents, Number of times it was sold,

    }
}
