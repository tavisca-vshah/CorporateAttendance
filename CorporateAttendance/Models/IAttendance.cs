using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateAttendance.Models
{
    interface IAttendanceRegister
    {
        bool MarkAttendance(int empId,DateTime checkInTime,DateTime CheckOutTime);
        List<AttendanceRecord> GetAttendanceSheet();
        AttendanceRecord GetEmployeeAttendance(Employee emp);
        void ModifyAttendanceRecord(AttendanceRecord record, AttendanceRecord newrecord);

    }
}
