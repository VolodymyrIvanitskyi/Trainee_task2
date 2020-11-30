using System;
using System.Collections.Generic;

namespace Trainee_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            var baseField = 5D;
            var height = 2D;
            var width = 3D;

            var shapes = new List<Shape>{ new Square(side),
                            new Circle(radius),
                            new Rectangle(height, width),
                            new Triangle(baseField, height),
                            new Square(1),
                            new Square(0.5)
            };

            shapes.Sort();

            foreach(var shape in shapes)
                Console.WriteLine(shape.Area +" ");

        }
    }
}
