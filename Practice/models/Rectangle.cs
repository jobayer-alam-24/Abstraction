using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
            Name = "Rectangle";
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}