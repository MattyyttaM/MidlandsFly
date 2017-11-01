using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models.AircraftModels
{
    public abstract class Aircraft
    {
        public int RegistrationNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool InFlight { get; set; }
        public float FlyingTime { get; set; }

        public string FlightNumber { get; set; }
        public Flight Flight { get; set; }

        //Might need to add a variable for an internal timer for flying - for the 200 hours
    }
}
