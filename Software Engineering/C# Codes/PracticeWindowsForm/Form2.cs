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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        int count = 0;
        //List of operators
         String[] operators = { "/", "*", "+", "-" };

        //Function to check whether the placement of operator is valid and
        private Boolean checkOperator()
        {
            String str = textMain.Text;
            if (str.Length == 0) {
                return false;
            }
            String lastStr = textMain.Text[textMain.Text.Length - 1].ToString();
            if (!operators.Contains(lastStr) && textMain.Text.Length > 0)
            {
                return true;
            }
            return false;

        }
        //Function to calculate the result
        private void calculateResult()
        {
            string expression = textMain.Text;
             try
            {
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");
                textMain.Text = result.ToString();
            }
            catch (Exception ex)
            {
               
                textMain.Text = ex.Message;
            }
        }



        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        //Buttons for Numbers
        private void button1_Click(object sender, EventArgs e)
        {
            String number=button1.Text;
            textMain.Text = textMain.Text + number;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String number = button3.Text;
            textMain.Text = textMain.Text + number;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String number = button0.Text;
            textMain.Text = textMain.Text + number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String number = button2.Text;
            textMain.Text = textMain.Text + number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String number = button4.Text;
            textMain.Text = textMain.Text + number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String number = button5.Text;
            textMain.Text = textMain.Text + number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String number = button6.Text;
            textMain.Text =textMain.Text+ number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String number = button7.Text;
            textMain.Text = textMain.Text + number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String number = button8.Text;
            textMain.Text = textMain.Text + number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String number = button9.Text;
            textMain.Text = textMain.Text + number;
        }
        //Function to clear all text
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textMain.Clear();
            
        }
        //Buttons to add all operators
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(checkOperator())
            {
                textMain.Text += "+";
                count = 1;
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (checkOperator())
            {
                textMain.Text += "*";
                count = 2;
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (checkOperator())
            {
                textMain.Text += "/";
                count = 3;
            }
        }
          private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (checkOperator())
            {
                textMain.Text += "-";
                count = 4;
            }
        }

        //Button for result
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            calculateResult();
        }
        //Button for backspace
        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            String str = textMain.Text;
            if (textMain.Text.Length>0) {
                textMain.Text = str.Substring(0, str.Length - 1);
            }
            
        }
        //Button for decimal number
        private void buttonDot_Click(object sender, EventArgs e)
        {
            
            if (textMain.Text.Length != 0 && textMain.Text[textMain.Text.Length-1]!='.') {
                textMain.Text = textMain.Text + ".";
            }
            
        }
    }
}
