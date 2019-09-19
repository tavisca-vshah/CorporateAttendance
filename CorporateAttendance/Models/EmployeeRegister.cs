using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateAttendance.Models
{
    public class EmployeeRegister : IEmployeeRegister
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void AddEmployeeRecord(Employee emp)
        {
            Employees.Add(emp);
        }

        public void AddEmployeesRecord(IEnumerable<Employee> employees)
        {
            Employees.AddRange(employees);
        }

        public Employee GetEmployeeRecord(int empId)
        {
            return Employees.SingleOrDefault(s => s.EmpId == empId);
        }

        public List<Employee> GetEmployeesRecord()
        {
            return Employees;
        }

        public void RemoveEmployeeRecord(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeeRecord(Employee emp)
        {
            for (var index = 0; index < Employees.Count; ++index)
            {
                if (Employees[index].EmpId == emp.EmpId)
                {
                    Employees[index] = emp;
                }
            }

            //var tempEmp = Employees.FirstOrDefault(e => e.EmpId == emp.EmpId);
            //if (tempEmp != null)
            //{
            //    tempEmp = emp;
            //}

        }
    }
}
