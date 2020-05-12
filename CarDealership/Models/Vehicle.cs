using Microsoft.AspNetCore.Mvc.Diagnostics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Vehicle
    {
        [key]
        public int VehicleId { get; set; }
        public string VIN { get; set; }
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

        public async Task VinCheck()
        {


            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string jsonResult = "";
            using (var requestMessage =
            new HttpRequestMessage(HttpMethod.Get, "http://api.carmd.com/v3.0/decode?vin=1GNALDEK9FZ108495"))
            {
                requestMessage.Headers.Authorization =
                    new AuthenticationHeaderValue( APIKeys.VinDecoderAuth);
                //requestMessage.Headers.Authorization =hhhhhhhhhhhhhhhh
                //    new AuthenticationHeaderValue("partner-token", APIKeys.VinDecoderPartnerToken);
                await client.SendAsync(requestMessage);
                jsonResult = await requestMessage.Content.ReadAsStringAsync();
            }
            VinDecode vinDecode = JsonConvert.DeserializeObject<VinDecode>(jsonResult);

        }
    }
   
   
}
