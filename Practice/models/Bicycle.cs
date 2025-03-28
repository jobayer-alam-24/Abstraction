using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string Brand)
        {
            this.Brand = Brand;
        }
        public override void Move()
        {
            Console.WriteLine($"{Brand} is moving...");
        }
        public override void Refuel()
        {
            Console.WriteLine($"{Brand} do not need refueling.");
        }
    }
}