using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWindowsForm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g=e.Graphics;
            g.DrawBezier(new Pen(Color.BlueViolet, 5),
                        new Point(50, 60), new Point(150, 100),
                           new Point(200,230),new Point(100,100)
                        );
            PointF point1 = new PointF(50.0f, 250.0f);
            PointF point2 = new PointF(100.0f, 25.0f);
            PointF point3 = new PointF(150.0f, 5.0f);
            PointF point4 = new PointF(250.0f, 50.0f);
            PointF point5 = new PointF(300.0f, 100.0f);

            PointF[] polygonPoints = { point1, point2, point3, point4, point5 };
            g.DrawPolygon(new Pen(Color.Chocolate, 10), polygonPoints);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect1=new Rectangle(10,10,50,50);
            Rectangle rect2 = new Rectangle(60, 60, 80, 100);

            SolidBrush brush1 = new SolidBrush(Color.Aquamarine);
            g.FillRectangle(brush1, rect1);

            LinearGradientBrush brush2 = new LinearGradientBrush(rect2,Color.Tan,Color.SandyBrown,
                LinearGradientMode.BackwardDiagonal);

            g.FillRectangle(brush2, rect2);

        }
    }
}
