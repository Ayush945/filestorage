using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class Rectangle:Shaape
    {
        
        private int x, y;
        private int X
        {
            get { return x; }
            set { x = value; }
        }
        private int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        }

        public override double Area()
        {
            return x * y;
        }
        public override double Perimeter()
        {
            return 2*(x + y);
        }
        public override string ToString()
        {
            base.ToString();
            return "Rectangle, Length and breadth=" + x + "" + y;

        }
    }
}
