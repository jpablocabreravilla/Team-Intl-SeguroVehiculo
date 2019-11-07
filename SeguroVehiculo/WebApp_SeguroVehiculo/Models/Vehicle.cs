using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_SeguroVehiculo.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
    }
}
