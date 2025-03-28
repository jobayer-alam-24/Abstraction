using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class Fish : Animal
    {
        public Fish(string name)
        {
            Name = name;
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says Bloop Bloop!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating fish food");
        }
    }
}