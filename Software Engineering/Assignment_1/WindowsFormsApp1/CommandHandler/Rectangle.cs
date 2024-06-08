using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Rectangle : ICommand
    {
        double x;
        double y;
        double width;
        double height;
        public Rectangle()
        {

        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public ICommand drawRectangle(String[] command,Graphics graphics)
        {
            float width, height;
            if (float.TryParse(command[1], out width) && float.TryParse(command[2], out height))
            {
                graphics.DrawRectangle(Pens.Black,(float) this.x, (float)this.y,width, height);
                return null;
            }
            else
            {
                throw new InvalidOperationException("Invalid arguments for 'moveTo'.");
            }
        }
       
    }
}
