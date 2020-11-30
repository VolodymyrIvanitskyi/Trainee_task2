using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Trainee_task2
{
    public abstract class Shape:IComparable
    {
        public abstract double Area { get; }

        
        private int Compare(double obj1, double obj2)
        {
            
            if (obj1 > obj2)
                return 1;
            if (obj1 < obj2)
                return -1;
            else
                return 0;
        }

        public int CompareTo(object obj)
        {
            Shape shape = (Shape)obj;

            return Compare(this.Area, shape.Area);
        }

    }
}
