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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black,2);
            g.DrawLine(myPen, 0, 0, 100, 100);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Point pt1 = new Point(0, 0);
            Point pt2= new Point(200, 200);
            Rectangle rect1 = new Rectangle(50, 80, 100, 130);
            Graphics g2 = e.Graphics;
            Pen myBlackPen=new Pen(Color.Black,5);

            g2.DrawLine(myBlackPen,pt1,pt2);
            g2.DrawLine(myBlackPen,0,50,200,50);

            g2.DrawEllipse(myBlackPen, 50, 50, 200, 100);

            g2.DrawRectangle(myBlackPen, rect1);
            myBlackPen.Dispose();
        }
    }
}
