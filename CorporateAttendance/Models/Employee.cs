using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateAttendance.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public EmployeeRole EmpRole { get; set; }
    }
}
