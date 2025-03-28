using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Speak();
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }
}