using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateAttendance.Models
{
    public class EmployeeRegister : IEmployeeRegister
    {
        public List<Employee> Employees { get; set; }

        public void AddEmployeeRecord(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void AddEmployeesRecord(IEnumerable<Employee> employees)
        {
            throw new NotImplementedException();
        }

        public void GetEmployeeRecord(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void GetEmployeesRecord()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployeeRecord(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeeRecord(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
