using System;
using System.Collections.Generic;
using System.Text;

namespace Trainee_task2
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double Width { get;}
        public double Height { get;}
        public override double Area => Width * Height;
    }
}
