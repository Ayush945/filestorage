using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle:Shape
    {
        private int x, y;

        public override double area()
        {
            return x * y;
        }
        public override double perimeter()
        {
            return 2 * (x + y);
        }
        public override string ToString()
        {
            base.ToString();
            return "Rectangle sides ="+x+", "+y;
        }
    }
}
