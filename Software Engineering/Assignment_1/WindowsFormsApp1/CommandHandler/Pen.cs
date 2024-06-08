using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class InkPen : ICommand
    {
      public ICommand changeColor(string[] commads, Graphics graphics)
        {
            string colorName = commads[1];
            
            if (Color.FromName(colorName).IsKnownColor)
            {
                Pen pen = new Pen(Color.FromName(colorName), 2);
                return null;
            }
            
               
           else
            {
                throw new InvalidOperationException("Invalid arguments for 'Pen'.");
            }
            
        }
    }
}
