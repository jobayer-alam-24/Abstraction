using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public abstract void Move();
        public virtual void Refuel()
        {
            Console.WriteLine($"{Brand} is Refueling...");
        }
    }
}