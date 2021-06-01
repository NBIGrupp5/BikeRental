using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class Booking : EntityBase
    {
        public int CustomerId { get; set; } //FK
        public int BikeId { get; set; } //FK
    }
}
