using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract double Area();
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}, Area: {Area()}");
        }
    }
}