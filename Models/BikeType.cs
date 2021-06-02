using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class BikeType : EntityBase
    {
        public string BikeTypeName { get; set; }
        public float BikeTypePrice { get; set; }

        public ICollection<Bike> Bikes { get; set; }

    }
}
