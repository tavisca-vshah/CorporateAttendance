using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateAttendance.Models
{
    interface IEmployeeRegister
    {
        void AddEmployeeRecord(Employee emp);
        void AddEmployeesRecord(IEnumerable<Employee> employees);
        void UpdateEmployeeRecord(Employee emp);
        void RemoveEmployeeRecord(Employee emp);
        void GetEmployeeRecord(Employee emp);
        void GetEmployeesRecord();
    }
}
