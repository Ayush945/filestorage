using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1.OptionClass.SpinBox
{
    public partial class SpinShape : Form
    {
        private Timer timer =new Timer();

        private int rotationAngle1 = 0;
        private int rotationAngle2 = 120;
        private int rotationAngle3 = 240;

        private Color[] triangleColors = { Color.Red, Color.Green, Color.Blue,Color.PaleGoldenrod,Color.Tan };
        private int colorIndex = 0;

        public SpinShape()
        {
            InitializeComponent();
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            rotationAngle1 = (rotationAngle1 + 5) % 360;
            rotationAngle2 = (rotationAngle2 + 5) % 360;
            rotationAngle3 = (rotationAngle3 + 5) % 360;
            if (timer.Interval % 1000 == 0)
            {
                colorIndex = (colorIndex + 1) % triangleColors.Length;
            }
            panel1.Invalidate();
        }

        private void SpinShape_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawSpinningShape(e.Graphics, rotationAngle1, panel1.Width / 4, panel1.Height / 2, triangleColors[0]);
            DrawSpinningShape(e.Graphics, rotationAngle2, panel1.Width / 2, panel1.Height / 4, triangleColors[1]);
            DrawSpinningShape(e.Graphics, rotationAngle3, panel1.Width * 3 / 4, panel1.Height * 3 / 4, triangleColors[2]);
        }
    

        private void DrawSpinningShape(Graphics g, int rotationAngle, int x, int y, Color color)
        {
            int size = 50;
            
            Point[] trianglePoints = new Point[3];
            trianglePoints[0] = new Point(x, y - size / 2);
            trianglePoints[1] = new Point(x - size / 2, y + size / 2);
            trianglePoints[2] = new Point(x + size / 2, y + size / 2);

            g.TranslateTransform(x, y);
            g.RotateTransform(rotationAngle);
            g.TranslateTransform(-x, -y);

            using (SolidBrush brush = new SolidBrush(color))
            {
                g.FillPolygon(brush, trianglePoints);
            }
        }
    }
}
