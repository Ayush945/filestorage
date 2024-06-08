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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void meniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.MdiParent = this;
            calculator.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5=new Form5();
            form5.MdiParent = this;
            form5.Show();
        }

        private void bitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6=new Form6();
            form6.MdiParent = this;
            form6.Show();
        }

        private void task1DrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7=new Form7();
            form7.MdiParent = this;
            form7.Show();
        }

        private void task2FreeDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8=new Form8();
            form8.MdiParent = this;
            form8.Show();
        }
    }
}
