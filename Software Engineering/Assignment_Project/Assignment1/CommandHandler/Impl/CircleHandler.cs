using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Handles the circle command, drawing circles on a panel.
    /// </summary>
    public class CircleHandler : ICommandHandler
    {
        private string command;
        private Carrier carrier;

        /// <summary>
        /// Initializes a new instance of the <see cref="CircleHandler"/> class.
        /// </summary>
        /// <param name="command">The circle command string.</param>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public CircleHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }

        /// <summary>
        /// Executes the circle command and draws a circle on the panel.
        /// </summary>
        public void execute()
        {
            if (validate())
            {
               string[] commandParts = command.Split(' ');

                float posX = carrier.PositionX;
                float posY = carrier.PositionY;
                float radius;
                if (carrier.Variables.ContainsKey(commandParts[1].Trim()))
                {
                    radius = carrier.Variables[commandParts[1].Trim()];
                }
                else
                {
                    radius = float.Parse(commandParts[1].Trim());
                }
                
                if (carrier.IsFilled)
                {
                    Brush brush = new SolidBrush(carrier.Color);
                    carrier.Graphics.FillEllipse(brush, posX, posY, radius, radius);
                }
                else
                {
                    Pen pen = new Pen(carrier.Color);
                    carrier.Graphics.DrawEllipse(pen, posX, posY, radius, radius);
                }
            }
        }

        /// <summary>
        /// Checks whether the parameters sent for the circle command are valid.
        /// </summary>
        /// <returns>True if valid; otherwise, false.</returns>
        public Boolean validate()
        {
            string[] commandParts = command.Split(' ');
            
            if (commandParts[1].Split(',').Length>1)
            {
                return false;
            }
         
            if (commandParts.Length != 2)
            {
                if(!carrier.IsTest)
                {
                    showError("Parameter required");
                }
                return false;
            }
            if (!float.TryParse(commandParts[1].Trim(), out float x))
            {
                if (!carrier.Variables.ContainsKey(commandParts[1].Trim()))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Parameter should be numbers");
                    }
                    
                    return false;
                }
                
            }

            if (x < 0)
            {
                if(!carrier.IsTest)
                {
                    showError("Parameter must be positive");
                }
                return false;
            }

            return true;
        }

        /// <summary>
        /// Throws an exception if an invalid parameter is detected.
        /// </summary>
        /// <param name="message">The error message for the invalid parameter.</param>
        public void showError(string message)
        {
            throw new IllegalParameterException(message);
        }
    }
}
