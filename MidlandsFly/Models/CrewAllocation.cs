using MidlandsFly.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models
{
    public class CrewAllocation
    {
        public int AllocationID { get; set; }
        public string FlightNumber { get; set; }
        public Flight Flight { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
