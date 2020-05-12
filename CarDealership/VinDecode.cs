using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership
{
    public class VinDecode
    {

        public class Decode
        {
            public Message message { get; set; }
            public Data data { get; set; }
        }

        public class Message
        {
            public int code { get; set; }
            public string message { get; set; }
            public string credentials { get; set; }
            public string version { get; set; }
            public string endpoint { get; set; }
            public int counter { get; set; }
        }

        public class Data
        {
            public int year { get; set; }
            public string make { get; set; }
            public string model { get; set; }
            public string manufacturer { get; set; }
            public string engine { get; set; }
            public string trim { get; set; }
            public string transmission { get; set; }
        }

    }
}
