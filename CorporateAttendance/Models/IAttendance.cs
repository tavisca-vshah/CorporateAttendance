using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateAttendance.Models
{
    interface IAttendanceRegister
    {
        bool CheckIn(int empId);
        bool CheckOut(int empId);
        AttendanceRecord GetAttendanceSheet();
        AttendanceRecord GetEmployeeAttendance(Employee emp);
        void ModifyAttendanceRecord(AttendanceRecord record, AttendanceRecord newrecord);

    }
}
