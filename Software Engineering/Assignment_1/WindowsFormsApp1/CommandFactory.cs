using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.POJO;

namespace WindowsFormsApp1
{
    internal class CommandFactory
    {
        public ICommand createCommand(string commandName,Carrier carrier)
        {
            switch (commandName.Split(' ')[0])
            {
                case "moveto":
                    return new MoveTo(commandName,carrier);
                case "drawto":
                    return new DrawTo();
                case "clear":
                    return new Clear();
                case "reset":
                    return new Reset();
                case "rectangle":
                    return new Rectangle();
                case "circle":
                    return new Circle();
                case "trianlge":
                    return new Triangle();
                case "fill":
                    return new Fill();
                case "pen":
                    return new InkPen();
                default:
                    throw new InvalidOperationException("Incorrect Syntax");
            }
        }
    }
}
