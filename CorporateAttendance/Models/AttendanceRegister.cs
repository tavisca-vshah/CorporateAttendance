using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateAttendance.Models
{
    public class AttendanceRegister : IAttendanceRegister
    {
        public List<AttendanceRecord> AttendanceSheet { get; set; }

        public bool CheckIn(int empId)
        {
            throw new NotImplementedException();
        }

        public bool CheckOut(int empId)
        {
            throw new NotImplementedException();
        }

        public AttendanceRecord GetAttendanceSheet()
        {
            throw new NotImplementedException();
        }

        public AttendanceRecord GetEmployeeAttendance(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void ModifyAttendanceRecord(AttendanceRecord record, AttendanceRecord newrecord)
        {
            throw new NotImplementedException();
        }
    }
}
