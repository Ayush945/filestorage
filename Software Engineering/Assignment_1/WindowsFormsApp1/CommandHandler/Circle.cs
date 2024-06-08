using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Circle : ICommand
    {
        float radius;
        float x;
        float y;
       public Circle()
        {

        }
        public ICommand drawCircle(string[] command,Graphics g)
        {
            float radius;
            if (float.TryParse(command[1], out radius))
            {
               
                return null;
            }
            else
            {
                throw new InvalidOperationException("Invalid arguments for 'Circle'.");
            }
            
        }

        public void Execute()
        {
            g.DrawEllipse(Pens.Black, this.x, this.y, radius, radius);
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
