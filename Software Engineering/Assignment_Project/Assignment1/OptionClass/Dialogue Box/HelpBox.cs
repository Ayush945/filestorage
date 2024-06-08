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
    /// Represents the Help Box for providing information about GPL commands.
    /// </summary>
    public partial class HelpBox : Form
    {
        /// <summary>
        /// Initializes a new instance of the HelpBox class.
        /// </summary>
        public HelpBox()
        {
            InitializeComponent();
            richTextBox1.Text = "Overview\r\nThis documentation outlines the available commands for a graphics system. The system supports various commands to draw shapes, control the pen, and manage the drawing canvas.\r\n\r\nCommand List\r\nThe following commands are supported:\r\n\r\n1. **circle**\r\n   - Syntax: `circle <radius>`\r\n   - Description: Draws a circle with the specified radius.\r\n\r\n2. **rectangle**\r\n   - Syntax: `rectangle <width>,<height>`\r\n   - Description: Draws a rectangle with the specified width and height.\r\n\r\n3. **triangle**\r\n   - Syntax: `triangle <side1>,<side2>,<side3>`\r\n   - Description: Draws a triangle with the specified side lengths.\r\n\r\n4. **drawto**\r\n   - Syntax: `drawto <x>,<y>`\r\n   - Description: Moves the pen to the specified coordinates without drawing.\r\n\r\n5. **moveto**\r\n   - Syntax: `moveto <x>,<y>`\r\n   - Description: Moves the pen to the specified coordinates, starting a new drawing.\r\n\r\n6. **linecircle**\r\n   - Syntax: `linecircle <radius>`\r\n   - Description: Draws a circle using lines with the specified radius.\r\n\r\n7. **reset**\r\n   - Syntax: `reset`\r\n   - Description: Clears the drawing canvas and resets the pen position.\r\n\r\n8. **clear**\r\n   - Syntax: `clear`\r\n   - Description: Clears the current drawing without resetting the pen position.\r\n\r\n9. **fill**\r\n   - Syntax: `fill`\r\n   - Description: Fills the interior of the last drawn shape.\r\n\r\n10. **pen**\r\n    - Syntax: `pen <colorname>`\r\n    - Description: Changes the pen color to the specified color name.\r\n\r\n11. **singleWordCommand**\r\n    - Syntax: `<command>`\r\n    - Description: Executes a command that requires no parameters.\r\n\r\n12. **singleNumberParameterCommand**\r\n    - Syntax: `<command> <number>`\r\n    - Description: Executes a command with a single numeric parameter.\r\n\r\n13. **doubleNumberParameterCommand**\r\n    - Syntax: `<command> <number1>,<number2>`\r\n    - Description: Executes a command with two numeric parameters separated by a comma.\r\n\r\n14. **doubleWordCommand**\r\n    - Syntax: `<command> <word>`\r\n    - Description: Executes a command with a single word parameter.\r\n\r\n15. **tripleNumberParameterCommand**\r\n    - Syntax: `<command> <number1>,<number2>,<number3>`\r\n    - Description: Executes a command with three numeric parameters separated by commas.\r\n\r\n## Parameter Guidelines\r\n- Numeric parameters (`<number>`) must be integers.\r\n- Coordinates (`<x>,<y>`) represent the x and y coordinates on the drawing canvas.\r\n- Color names for the `pen` command must be valid.\r\n\r\n## Examples\r\n- `circle 5`: Draws a circle with a radius of 5.\r\n- `rectangle 8,12`: Draws a rectangle with width 8 and height 12.\r\n- `triangle 3,4,5`: Draws a triangle with side lengths 3, 4, and 5.\r\n- `drawto 10,20`: Moves the pen to the point (10, 20) without drawing.\r\n- `moveto 30,40`: Moves the pen to the point (30, 40) and starts a new drawing.\r\n- `linecircle 6`: Draws a circle using lines with a radius of 6.\r\n- `reset`: Clears the canvas and resets the pen position.\r\n- `clear`: Clears the current drawing without resetting the pen position.\r\n- `fill`: Fills the interior of the last drawn shape.\r\n- `pen red`: Changes the pen color to red.";
            richTextBox1.ReadOnly = true;

            Font newFont = new Font(label1.Font.FontFamily, 14, label1.Font.Style);
            Font newFont1 = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);

            label1.Font = newFont;
            richTextBox1.Font = newFont1;
        }

        /// <summary>
        /// Handles the Click event of the close button.
        /// Closes the Help Box.
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
