using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Triangle : ICommand
    {
        float height;
        int x, y;
        public Triangle()
        {

        }
        public ICommand drawTriangle(string[] command, Graphics graphics)
        {
            int height;
            if (int.TryParse(command[1],out height))
            {
                Point[] trianglePoints = new Point[]
                {
                    new Point(this.x, this.y - height / 2),
                new Point(this.x - (int)(height * Math.Sqrt(3) / 2), this.y + height / 2),
                new Point(this.x + (int)(height * Math.Sqrt(3) / 2), this.y + height / 2)
                };

                graphics.DrawPolygon(Pens.Black, trianglePoints);
                return null;
            }
            else
            {
                throw new InvalidOperationException("Invalid arguments for 'Triangle'.");
            }

        }
      

    }
}
