using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment1.OptionClass.FreeDrawBox
{
    public partial class DrawBox : Form
    {
        Graphics g;
        public DrawBox()
        {
            InitializeComponent();
            g=panel1.CreateGraphics();
            panel1.BackColor = Color.White;
        }
        bool startPaint = false;
        int? initX = null;
        int? initY = null;

        bool drawSquare=false;
        bool drawCircle=false;
        bool drawTriangle=false;
        bool drawRectangle=false;

        private void DrawBox_Load(object sender, EventArgs e)
        {

        }

        private void penButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                penColorButton.BackColor = dialog.Color;
            }
        }

        private void canvasButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog= new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                canvasColorButton.BackColor = dialog.Color;
                panel1.BackColor= dialog.Color;
            }
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            drawTriangle = true;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void squareButton_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                Pen p = new Pen(penColorButton.BackColor, float.Parse(thicknessText.Text));
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                SolidBrush sb = new SolidBrush(penColorButton.BackColor);
                g.FillRectangle(sb, e.X, e.Y, int.Parse(sizeText.Text), int.Parse(sizeText.Text));
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(penColorButton.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(sizeText.Text), int.Parse(sizeText.Text));
                startPaint = false; drawRectangle = false;

            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(penColorButton.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(sizeText.Text), int.Parse(sizeText.Text));
                startPaint = false; drawCircle = false;
            }
            if (drawTriangle)
            {
                SolidBrush sb=new SolidBrush(penColorButton.BackColor);
                int triangleBase = int.Parse(sizeText.Text);
                int height = int.Parse(sizeText.Text)+10;
                int posX=e.X;
                int posY=e.Y;
                Point point1 = new Point(posX, posY);
                Point point2 = new Point(posX + triangleBase, posY);
                Point point3 = new Point(posX + triangleBase / 2, posY + height);
                g.FillPolygon(sb,new Point[] { point1,point2,point3});
                startPaint= false; drawTriangle = false;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            panel1.BackColor = Color.White;
            canvasColorButton.BackColor = Color.White;
        }
    }
}
