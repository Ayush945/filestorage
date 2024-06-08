using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Validation
{
    internal class ValidateInteger
    {
        public Boolean checkParameterForMoveTo(string command)
        {
            string[] arrayCommand=command.Split(' ');
            float x, y;
            if(arrayCommand.Length == 3 ) {
                if (float.TryParse(arrayCommand[1], out x) && float.TryParse(arrayCommand[2],out y ))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Insert Numbers as parameters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Only two Parameter allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }
    }
}
