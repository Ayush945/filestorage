using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace PracticeWindowsForm
{
    public partial class Form6 : Form
    {
        Bitmap myBitmap;
        Graphics g;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            myBitmap = new Bitmap(640,460);
            g= Graphics.FromImage(myBitmap);

            Pen p = new Pen(Color.Red, 2);
            g.DrawLine(p, 0, 0, 640, 480);

            Graphics windowG=e.Graphics;
            windowG.DrawImageUnscaled(myBitmap, 0, 0);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            myBitmap.Save("e:\\image1.jpg",ImageFormat.Jpeg);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("e:\\image1.jpg");
        }
    }
}
