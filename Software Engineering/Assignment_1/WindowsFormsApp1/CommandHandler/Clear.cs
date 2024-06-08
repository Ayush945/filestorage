using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Clear : ICommand
    {
      public ICommand clearPanel(Graphics g,Panel panel)
        {
            g.Clear(panel.BackColor);
            return null; 
        }
    }
}
