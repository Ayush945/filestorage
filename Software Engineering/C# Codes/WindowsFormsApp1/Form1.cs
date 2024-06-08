using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       private enum Shape { Rectangle,Circle};
       private Shape selectedShape = Shape.Rectangle;
       private int numberOfShapes = 0;
       public Form1()
        {
            InitializeComponent();
           

        }
       private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g=panel1.CreateGraphics();
            if (selectedShape == Shape.Rectangle)
            {
                g.DrawRectangle(Pens.Black, e.X, e.Y, 50, 50);
                numberOfShapes++;
            }
            else
            {
                g.DrawEllipse(Pens.Black, e.X - 25, e.Y - 25, 50, 50);
                numberOfShapes++;
            }
            textBox1.Text = numberOfShapes.ToString();


        }

        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = Shape.Rectangle;
        }

        private void circleRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
           selectedShape=Shape.Circle;

        }

    }
}
