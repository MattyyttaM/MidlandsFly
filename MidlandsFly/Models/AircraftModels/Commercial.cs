using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models.AircraftModels
{
    public class Commercial : Aircraft
    {
        /// <summary>
        /// Get the total number of seats on the plane.
        /// </summary>
        public int Seats { get; set; }
    }
}
