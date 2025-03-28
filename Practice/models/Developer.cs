using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class Developer : Employee
    {
        public Developer(string devName, string devID) : base(devName, devID){}
        public override void PerformTask()
        {
            Console.WriteLine($"{EmployeeName} is writing code.");
        }
        public override void AttendMeeting()
        {
            Console.WriteLine($"{EmployeeName} is attending a code review meeting.");
        }
    }
}