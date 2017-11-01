using MidlandsFly.Models.AircraftModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models
{
    public class Job
    {
        [Key]
        public int JobNumber { get; set; }
        public int MaintenanceID { get; set; }
        public MaintenanceRecord Record { get; set; }
        public string RegistrationNo { get; set; }
        public Aircraft Aircraft { get; set; }

    }
}
