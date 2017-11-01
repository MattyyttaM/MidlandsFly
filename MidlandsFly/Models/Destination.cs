using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models
{
    public class Destination
    {   
        [Key]
        public string AirportCode { get; set; }
        public float FlightLength { get; set; }
        public string FlightNumber { get; set; }
        public ICollection<Flight> Flight { get; set; }
    }
}
