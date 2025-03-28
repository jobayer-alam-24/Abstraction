using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says GHEU GHEU!");
        }  
    }
}