using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class Car : Vehicle
    {
        public Car(string Brand)
        {
            this.Brand = Brand;
        }
        public override void Move()
        {
            Console.WriteLine($"{Brand} is moving...");
        }
        public override void Refuel()
        {
            Console.WriteLine($"{Brand} is Refueling...");
        }
    }
}