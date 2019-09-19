using CorporateAttendance.Helpers;
using CorporateAttendance.Models;
using System;
using Xunit;

namespace CorporateAttendanceFixture
{
    public class EmployeeRegisterFixture
    {
        [Fact]
        public void EmployeeRegister_ShouldAddEmployee()
        {
            var employee = EmployeeFactory.GetEmployeeRecord();
            var employeeRegister = new EmployeeRegister();
            employeeRegister.AddEmployeeRecord(employee);
            Assert.Equal(employee, employeeRegister.GetEmployeesRecord()[0]);
        }
        [Fact]
        public void EmployeeRegister_ShouldAddEmployees()
        {
            var employees = EmployeeFactory.GetEmployeesRecord();
            var employeeRegister = new EmployeeRegister();
            employeeRegister.AddEmployeesRecord(employees);
            Assert.Equal(employees, employeeRegister.GetEmployeesRecord());
        }
        [Fact]
        public void EmployeeRegister_ShouldReadEmployee()
        {
            var employees = EmployeeFactory.GetEmployeesRecord();
            var employeeRegister = new EmployeeRegister();
            employeeRegister.AddEmployeesRecord(employees);

            Assert.NotEqual(EmployeeFactory.GetEmployeeRecord(), employeeRegister.GetEmployeeRecord(5));
        }
        [Fact]
        public void EmployeeRegister_ShouldReadEmployees()
        {
            var employees = EmployeeFactory.GetEmployeesRecord();
            var employeeRegister = new EmployeeRegister();
            employeeRegister.AddEmployeesRecord(employees);

            Assert.Equal(employees, employeeRegister.GetEmployeesRecord());
        }


        [Fact]
        public void EmployeeFixture_ShouldUpdateEmployee()
        {
            var employees = EmployeeFactory.GetEmployeesRecord();
            var employeeRegister = new EmployeeRegister();
            employeeRegister.AddEmployeesRecord(employees);
            var newEmployee = new Employee()
            {
                EmpId = 5,
                EmpName = "emp5",
                EmpRole = EmployeeRole.Admin

            };
            employeeRegister.UpdateEmployeeRecord(newEmployee);
            Assert.Equal(newEmployee,employeeRegister.GetEmployeeRecord(5));
        }
    }
}
