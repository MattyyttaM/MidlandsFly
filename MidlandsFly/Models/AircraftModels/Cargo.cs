using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models.AircraftModels
{
    public class Cargo : Aircraft
    {
        /// <summary>
        /// Get/Set the capacity, value represents Tonnes.
        /// </summary>
        public float Capacity { get; set; }

    }
}
