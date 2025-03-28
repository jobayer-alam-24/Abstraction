using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class Manager : Employee
    {
        public Manager(string ManagerName, string ManagerID) : base(ManagerName, ManagerID){}
        public override void PerformTask()
        {
            Console.WriteLine($"{EmployeeName} is managing the team.");
        }
        public override void AttendMeeting()
        {
            Console.WriteLine($"{EmployeeName} is attending a management meeting.");
        }
    }
}