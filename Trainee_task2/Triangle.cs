using System;
using System.Collections.Generic;
using System.Text;

namespace Trainee_task2
{
    public class Triangle : Shape
    {
        public Triangle(double baseField, double height)
        {
            BaseField = baseField;
            Height = height;
        }
        public double BaseField { get; }
        public double Height { get; }

        public override double Area => BaseField/2*Height;
    }
}
