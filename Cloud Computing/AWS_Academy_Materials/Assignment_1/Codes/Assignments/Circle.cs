using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Circle:Shape
    {
        private double radius;
        private int x, y;

        public override double area()
        {
            return radius*radius*Math.PI;
        }
        public override double perimeter()
        {
            return 2.0*Math.PI*radius;
        }
        public override string ToString()
        {
            base.ToString();
            return "Circle, Centre ="+x+","+y+
                ", Radius="+radius;

        }
    }
}
