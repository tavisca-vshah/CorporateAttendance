using CorporateAttendance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateAttendance.Helpers
{
    public class EmployeeFactory
    {
        public static IEnumerable<Employee> GetEmployeesRecord()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpId = 1, EmpName = "emp1" , EmpRole = EmployeeRole.Admin},
                new Employee(){EmpId = 2, EmpName = "emp2" , EmpRole = EmployeeRole.NonAdmin},
                new Employee(){EmpId = 3, EmpName = "emp3" , EmpRole = EmployeeRole.NonAdmin},
                new Employee(){EmpId = 4, EmpName = "emp4" , EmpRole = EmployeeRole.NonAdmin},
                new Employee(){EmpId = 5, EmpName = "emp5" , EmpRole = EmployeeRole.NonAdmin},
                new Employee(){EmpId = 6, EmpName = "emp6" , EmpRole = EmployeeRole.NonAdmin},
                new Employee(){EmpId = 7, EmpName = "emp7" , EmpRole = EmployeeRole.Admin},
                new Employee(){EmpId = 8, EmpName = "emp8" , EmpRole = EmployeeRole.NonAdmin},
                new Employee(){EmpId = 9, EmpName = "emp9" , EmpRole = EmployeeRole.Admin},
                new Employee(){EmpId = 10, EmpName = "emp10" , EmpRole = EmployeeRole.NonAdmin},

            };
            return employees;
        }

        public static Employee GetEmployeeRecord()
        {
            return new Employee() { EmpId = 100, EmpName = "temp100", EmpRole = EmployeeRole.NonAdmin };
        }
    }
}
