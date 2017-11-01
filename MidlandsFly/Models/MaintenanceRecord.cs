using MidlandsFly.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models
{
    public class MaintenanceRecord
    {
        [Key]
        public int MaintenanceID { get; set; }
        public string Description { get; set; }
        public DateTime CompletionDate { get; set; }
        public int EmployeeID { get; set; }
        public GroundCrew CrewMember { get; set; }
    }
}
