using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public abstract class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeID { get; set; }
        public Employee(string employeeName, string employeeID)
        {
            EmployeeName = employeeName;
            EmployeeID = employeeID;
        }
        public abstract void PerformTask();
        public virtual void AttendMeeting()
        {
            Console.WriteLine($"{EmployeeName} is attending a meeting.");
        }
    }
}