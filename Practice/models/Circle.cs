using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double Radius)
        {
            this.Radius = Radius;
            Name = "Circle";
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}