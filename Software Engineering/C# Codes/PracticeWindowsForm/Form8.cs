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
    public partial class Form8 : Form
    {
        Graphics g;

        
        public Form8()
        {
            InitializeComponent();
           g=panel1.CreateGraphics();
            panel1.BackColor=Color.White;
            
        }
        bool startPaint = false;

        int? initX = null;
        int? initY = null;

        bool drawSquare = false;
        bool drawCircle = false;
        bool drawRectangle = false;

        private void penColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                colorOfPen.BackColor = dlg.Color;
            }
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            ColorDialog dlg=new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                canvas.BackColor = dlg.Color;
                panel1.BackColor = dlg.Color;
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
               
                Pen p = new Pen(colorOfPen.BackColor, float.Parse(penThickness.Text));
                g.DrawLine(p,new Point(initX ?? e.X,initY ?? e.Y), new Point(e.X,e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                SolidBrush sb=new SolidBrush(colorOfPen.BackColor);
                g.FillRectangle(sb, e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(colorOfPen.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(textBox1.Text),int.Parse(textBox1.Text));
                startPaint = false; drawRectangle = false;  

            }
            if(drawCircle)
            {
                SolidBrush sb = new SolidBrush(colorOfPen.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                startPaint = false; drawCircle = false;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            panel1.BackColor= Color.White;
            canvas.BackColor = Color.White;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit?","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
