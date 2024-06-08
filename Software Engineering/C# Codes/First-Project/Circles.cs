using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class Circles:Shaape
    {
        private double radius;
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
         public Circles(double radius,int x,int y)
        {
            this.radius = radius;
            this.x = x; 
            this.y = y;
        }
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
        public override double Perimeter()
        {
            return 2.0*Math.PI*radius;
        }
        public override string ToString()
        {
            base.ToString();
            return "Circle, Centre="+x+""+y+",Radius="+radius;

        }
        
    }
}
