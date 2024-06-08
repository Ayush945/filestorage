using Assignment1.HelperClass;
using Assignment1.OptionClass;
using Assignment1.OptionClass.Dialogue_Box;
using Assignment1.OptionClass.FreeDrawBox;
using Assignment1.OptionClass.SpinBox;
using Assignment1.OptionClass.TimerBox;
using Assignment1.POJO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Assignment1
{
    /// <summary>
    /// Represents the main form of the application.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Object of text store class
        /// </summary>
        private TextStore textStore=new TextStore();
        /// <summary>
        /// field for panel position
        /// </summary>
        private float posX, posY;
        /// <summary>
        /// field for the graphics of panel
        /// </summary>
        private Graphics graphics;
        /// <summary>
        /// field for color
        /// </summary>
        private Color color = Color.Black;
        /// <summary>
        /// field for if fill is on or off
        /// </summary>
        private Boolean isFilled;
        /// <summary>
        /// field to carry other fields
        /// </summary>
        private Carrier carrier;
        /// <summary>
        /// field for variable storage with its value
        /// </summary>
        private Dictionary<string, float> variables = new Dictionary<string, float>();
        /// <summary>
        /// field for method storage with its line number and parameter
        /// </summary>
        private Dictionary<string,(int, int)> methodName=new Dictionary<string, (int, int)>();
        /// <summary>
        /// field to check for test
        /// </summary>
        private bool isTest=false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            graphics = drawPanel.CreateGraphics();
            drawPanel.Paint += drawPanel_Paint;
            carrier = new Carrier(posX, posY, graphics, drawPanel, color, isFilled, variables,methodName,isTest);
            label1.Text = "Current position: "+posX+" , "+posY;
            
            textBox1.TextChanged += textBox1_TextChanged;
            multiLineTextBox.TextChanged += multiLineTextBox_TextChanged;
            secondmultilinetextBox.TextChanged += secondmultilinetextBox_TextChanged;
           
            
        }
        /// <summary>
        /// Handles the Click event of the "Run" button.
        /// </summary>
        private void runButton_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string textCommand = text.Trim().ToLower();

            string multiLine = multiLineTextBox.Text;
            string multiTextCommand = multiLine.Trim().ToLower();

            string secondMultiLine = secondmultilinetextBox.Text;
            string secondMultiTextCommand = secondMultiLine.Trim().ToLower();

            if (textCommand.Equals("run"))
            {
                ManualResetEvent mre = new ManualResetEvent(false);

                // Create and start the first thread
                Thread thread1 = new Thread(() =>
                {
                    CommandParser multiLineExecute = new CommandParser(carrier);
                    multiLineExecute.runMultiCommand(multiTextCommand);
                    mre.Set(); // Signal completion
                });
                thread1.Start();

                // Wait for the first thread to complete
                mre.WaitOne();

                // Create and start the second thread
                Thread thread2 = new Thread(() =>
                {
                    CommandParser multiLineExecute = new CommandParser(carrier);
                    multiLineExecute.runMultiCommand(secondMultiTextCommand);
                });
                thread2.Start();
            }
            else {
                CommandParser commandParser = new CommandParser(carrier);
                commandParser.runCommand(textCommand);
            }
            label1.Text = "Current position: " + carrier.PositionX + " , " + carrier.PositionY;
        }

        /// <summary>
        /// Handles the Click event of the "Exit" menu item.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Handles the Click event of the "About" menu item.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
        /// <summary>
        /// Handles the Click event of the "Help" menu item.
        /// </summary>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpBox helpBox = new HelpBox();
            helpBox.ShowDialog();

        }

        /// <summary>
        /// Handles the Click event of the "Save" menu item for first textbox.
        /// </summary>
        private void firstTextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandParser commandParser = new CommandParser();
            commandParser.saveTextFile(multiLineTextBox.Text);
        }
        /// <summary>
        /// Handles the Click event of the "Save" menu item for second textbox.
        /// </summary>
        private void secondTextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandParser commandParser = new CommandParser();
            commandParser.saveTextFile(secondmultilinetextBox.Text);
        }
        /// <summary>
        /// Save the image of panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandParser commandParser = new CommandParser();
            commandParser.saveImageFile(drawPanel,textStore.FirstMultiText);
        }
        /// <summary>
        /// Load the image in panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommandParser commandParser = new CommandParser();
            commandParser.loadImageFile(drawPanel);
        }

        /// <summary>
        /// Handles the Click event of the "Syntax" button.
        /// </summary>
        private void syntaxButton_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string textCommand = text.Trim().ToLower();

            string multiLine = multiLineTextBox.Text;
            string multiTextCommand = multiLine.Trim().ToLower();

            string secondMultiLine = secondmultilinetextBox.Text;
            string secondMultiTextCommand = secondMultiLine.Trim().ToLower();
            
            ManualResetEvent mre = new ManualResetEvent(false);
            Thread thread1 = new Thread(() =>
            {
                CommandParser multiLineExecute = new CommandParser(carrier);
                multiLineExecute.checkCommand(multiTextCommand);
                mre.Set();
            });
            thread1.Start();

            mre.WaitOne();
            Thread thread2 = new Thread(() =>
            {
                CommandParser multiLineExecute = new CommandParser(carrier);
                multiLineExecute.checkCommand(secondMultiTextCommand);
            });
            thread2.Start();
            
            
        }
    

        /// <summary>
        /// Handles the Click event of the "Load" menu item for first textbox.
        /// </summary>
        private void firstTextboxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommandParser commandParser = new CommandParser();
            commandParser.loadTextFile(multiLineTextBox);
        }
        /// <summary>
        /// Handles the Click event of the "Load" menu item for second textbox.
        /// </summary>
        private void secongTextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandParser commandParser = new CommandParser();
            commandParser.loadTextFile(secondmultilinetextBox);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandParser commandParser=new CommandParser();
            commandParser.saveImageFile(drawPanel,textStore.FirstMultiText);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void multiLineTextBox_TextChanged(object sender, EventArgs e)
        {
            textStore.FirstMultiText.Clear();
            textStore.FirstMultiText.Add(multiLineTextBox.Text.Trim().ToLower());
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textStore.SingleText.Add(textBox1.Text);
        }

        private void countdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountDown countDown=new CountDown();
            countDown.ShowDialog();
        }

        private void spinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpinShape spinShape=new SpinShape();
            spinShape.ShowDialog();
        }

        private void freeDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawBox drawBox = new DrawBox();
            drawBox.ShowDialog();
        }

        private void secondmultilinetextBox_TextChanged(object sender, EventArgs e)
        {
            textStore.SecondMultiText.Add(secondmultilinetextBox.Text);
        }
    }
}
