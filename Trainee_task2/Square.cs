using System;
using System.Collections.Generic;
using System.Text;

namespace Trainee_task2
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
        }
        public double Side { get; }
        public override double Area => Side*Side;

    }
}
