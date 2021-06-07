using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRental.RequestsAndResponses
{
    public class BikeTypeResponse
    {
        public int Id { get; set; }
        public string BikeTypeName { get; set; }
        public float BikeTypePrice { get; set; }
        public string BikeTypeDescription { get; set; }
        public string BikeTypeImage { get; set; }
    }
}
