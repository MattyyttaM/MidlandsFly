using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidlandsFly.Models.EmployeeModels
{
    public class GroundCrew : Employee
    {
        public int MaintenanceID { get; set; }

        public ICollection<MaintenanceRecord> Maintenance { get; set; }

    }
}
