using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models.EmployeeModels
{
    public class FlightCrew : Employee
    {
        public float FlyingTime { get; set; }
        public int AllocationID { get; set; }
        public CrewAllocation Allocation { get; set; }
    }
}
