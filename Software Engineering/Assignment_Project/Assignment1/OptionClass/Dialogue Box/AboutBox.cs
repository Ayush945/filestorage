using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1.OptionClass.Dialogue_Box
{
    /// <summary>
    /// Represents the About Box for the application.
    /// </summary>
    public partial class AboutBox : Form
    {
        /// <summary>
        /// Initializes a new instance of the AboutBox class.
        /// </summary>
        public AboutBox()
        {
            InitializeComponent();
            richTextBox1.Text = "  Welcome to our Graphical Programming Language application.\n" +
                              "  This software provides an intuitive and user-friendly,\n" +
                              "  environment for creating and executing graphical programs.\n" +
                              "  Whether you are a beginner or an experienced developer,\n" +
                              "  our application aims to simplify the process of creating\n" +
                              "  and visualizing.\n\n" +
                              "  To learn about the command please click on Help option \n\n" +
                              "  Thank you for choosing our application. We hope you find\n" +
                              "  it both powerful and user-friendly. If you have any questions\n" +
                              "  or feedback, feel free to contact our support team.";
            richTextBox1.ReadOnly = true;

            label1.Text = "About Graphical Programming Language Application";

            Font newFont = new Font(label1.Font.FontFamily, 14, label1.Font.Style);
            Font newFont2 = new Font(richTextBox1.Font.FontFamily, 11, richTextBox1.Font.Style);

            label1.Font = newFont;
            richTextBox1.Font = newFont2;
        }

        /// <summary>
        /// Handles the Click event of the close button.
        /// Closes the About Box.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the TextChanged event of the richTextBox1 control.
        /// </summary>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        /// <summary>
        /// Handles the Click event of the label1 control.
        /// </summary>
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
