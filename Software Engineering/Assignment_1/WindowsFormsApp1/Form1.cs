using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.POJO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        Pen pen;
        bool isFilled;
        public Form1()
        {
            InitializeComponent();
            graphics = drawPanel.CreateGraphics();
            drawPanel.Paint += drawPanel_Paint;
            
        }
        

        private void runButton_Click(object sender, EventArgs e)
        {
            Carrier carrier = new Carrier(graphics, drawPanel, pen, isFilled);
            try
            {
                string text = singleLineTextBox.Text;
                CommandParser parser = new CommandParser(carrier);
                parser.runCommand(text);
                
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void singleLineTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
           

        }
    }
}
