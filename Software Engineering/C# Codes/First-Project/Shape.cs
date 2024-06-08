using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class Shape
    {

        int x;
        int y;
        public Shape(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; } 
            set { y = value; }
        }
        public virtual void  Area()
        {
            Console.WriteLine(x*y);
            Console.Read();
        }
    }
}
