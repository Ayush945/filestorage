using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWindowsForm
{
    public partial class Form7 : Form
    {
        bool mouseDown = false;
        Bitmap myBitmap;

        public Form7()
        {
            InitializeComponent();
            myBitmap = new Bitmap(Size.Width,Size.Height);
            Graphics g = Graphics.FromImage(myBitmap);
            g.DrawEllipse(new Pen(Color.Blue, 5), 50, 50, 200, 100);
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(myBitmap, 0, 0);
        }

        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form7_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown=false;
        }

        private void Form7_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g=Graphics.FromImage(myBitmap);
            if (mouseDown == true)
            {
                g=Graphics.FromImage(myBitmap);
                g.DrawEllipse(new Pen(Color.Red, 2), 50, 50, 200, 100);
                Pen myRedPen =new Pen(Color.Red, 25);
                g.DrawLine(myRedPen, e.X, e.Y, e.X + 1, e.Y + 1);
                myRedPen.Dispose();
                Refresh();
            }
        }
    }
}
