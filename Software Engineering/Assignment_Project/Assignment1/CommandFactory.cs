using Assignment1.CommandHandler;
using Assignment1.CommandHandler.Impl;
using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Assignment1
{
    /// <summary>
    /// This class creates the object of the class according to passed parameter
    /// </summary>
    internal class CommandFactory
    {
        /// <summary>
        /// Method which creates the object using switch case
        /// </summary>
        /// <param name="command">Command given by user</param>
        /// <param name="carrier">POJO class to carry data</param>
        /// <returns>Object according to commad</returns>
        /// <exception cref="IllegalSyntaxException">If no such class, throws errro</exception>
        public ICommandHandler createInstance(string command,Carrier carrier)
        {
            switch (command.Split(' ')[0].Trim())
            {
                case "moveto":
                    return new MoveToHandler(command,carrier);
                case "drawto":
                    return new DrawToHandler(command,carrier);
                case "clear":
                    return new ClearHandler(command,carrier);
                case "reset":
                    return new ResetHandler(command,carrier);
                case "rectangle":
                    return new RectangleHandler(command,carrier);
                case "circle":
                    return new CircleHandler(command,carrier);
                case "triangle":
                    return new TriangleHandler(command,carrier);
                case "fill":
                    return new FillHandler(command,carrier);
                case "pen":
                    return new InkPenHandler(command,carrier);
                case "rangoli":
                    return new RangoliHandler(command, carrier);
                default:
                    throw new IllegalSyntaxException("Incorrect Syntax");
            }
            
        }
    }
}
