using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MidlandsFly.Models.AircraftModels;

namespace MidlandsFly.Models
{
    public class Flight
    {
        public string FlightNumber { get; set; }
        public string RegistrationNo { get; set; }
        public ICollection<Aircraft> Aircraft { get; set; }
        public string AirportCode { get; set; }
        public Destination Destination { get; set; }
        public int AllocationID { get; set; }
        public CrewAllocation CrewAllocated { get; set; }
    }
}
