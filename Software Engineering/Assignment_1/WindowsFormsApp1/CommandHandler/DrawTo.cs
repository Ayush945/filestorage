using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class DrawTo:ICommand
    {
        private double x;
        private double y;
        private Graphics graphics;
        

        public DrawTo()
        {

        }
        public DrawTo(Graphics graphics) {
            this.graphics = graphics;
        }

        public ICommand checkParameters(string[] command, Graphics graphics)
        {
            double x, y;
            if (double.TryParse(command[1], out x) && double.TryParse(command[2], out y))
            {
                DrawTo drawToCommand = new DrawTo(graphics);
                drawToCommand.drawToPosition(x, y, graphics);
                return drawToCommand;
            }
            else
            {
                throw new InvalidOperationException("Invalid arguments for 'moveTo'.");
            }
        }

        public void drawToPosition(double x, double y, Graphics g) 
        {
            g.DrawLine(Pens.Black,(float)this.x,(float)this.y,(float) x,(float) y);
            this.x= x;
            this.y= y;
        }

    }
}
