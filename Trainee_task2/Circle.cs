using System;
using System.Collections.Generic;
using System.Text;

namespace Trainee_task2
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get;}
        public override double Area => Radius*Radius*Math.PI;
    }
}
