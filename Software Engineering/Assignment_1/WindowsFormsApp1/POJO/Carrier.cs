using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.POJO
{
    internal class Carrier
    {
        Graphics graphics;
        Panel panel;
        Pen pen;
        bool isFilled;

        public Carrier(Graphics g,Panel p, Pen pen,Boolean isFilled)
        {
            this.graphics = g;
            this.panel = p;
            this.pen = pen;
            this.isFilled = isFilled;
        }
        public Graphics Graphics
        {
            get { return graphics; }
            set {  graphics = value; }
        }
        public Panel Panel
        {
            get { return panel; }
            set { panel = value; }
        }
        public Pen Pen { get { return pen; } set { pen = value; } }

        public Boolean IsFilled
        {
            get { return isFilled; }
            set { isFilled = value; }
        }
    }
}
