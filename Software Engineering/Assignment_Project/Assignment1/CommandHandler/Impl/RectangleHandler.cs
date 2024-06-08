using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System.Drawing;
using System;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Handles the rectangle command by drawing a rectangle on the panel.
    /// </summary>
    public class RectangleHandler : ICommandHandler
    {
        private Carrier carrier;
        private string command;

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleHandler"/> class.
        /// </summary>
        /// <param name="command">The rectangle command string.</param>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public RectangleHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
            
        }
        /// <summary>
        /// Executes the rectangle command by drawing a rectangle on the panel.
        /// </summary>
        public void execute()
        {
            if (validate())
            {
                string[] commandParts = command.Trim().Split(' ');
                string[] parameters = commandParts[1].Split(',');

                float posX = carrier.PositionX;
                float posY = carrier.PositionY;
                Pen pen = new Pen(carrier.Color);

                float length;
                float breadth;

                string key1 = parameters[0].Trim();
                string key2 = parameters[1].Trim();

                bool param1 = carrier.Variables.ContainsKey(key1);
                bool param2 = carrier.Variables.ContainsKey(key2);

                if (param1)
                {
                    length = carrier.Variables[key1];

                }
                else
                {
                    length = float.Parse(parameters[0]);
                }
                if (param2)
                {
                    breadth = carrier.Variables[key2];
                }
                else
                {

                    breadth = float.Parse(parameters[1]);
                }
                if (carrier.IsFilled)
                {
                    SolidBrush brush = new SolidBrush(carrier.Color);
                    carrier.Graphics.FillRectangle(brush, posX, posY, length, breadth);
                }
                else
                {
                    carrier.Graphics.DrawRectangle(pen, posX, posY, length, breadth);
                    
                    
                }
            }
        }

        /// <summary>
        /// Validates the parameters of the rectangle command.
        /// </summary>
        /// <returns>True if validation succeeds; otherwise, false.</returns>
        public Boolean validate()
        {
            string[] commandParts = command.Split(' ');

            if (commandParts.Length != 2)
            {
                if (!carrier.IsTest) { showError("Parameter required"); }

                return false;
            }

            string[] parameters = commandParts[1].Trim().Split(',');

            if (parameters.Length != 2)
            {
                if (!carrier.IsTest) { showError("Wrong number of parameters"); }

                return false;
            }

            if (!float.TryParse(parameters[0].Trim(), out float x))
            {
                if (!carrier.Variables.ContainsKey(parameters[0]))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Parameters should be numbers");
                    }

                    return false;
                }
            }
            if (!float.TryParse(parameters[1].Trim(), out float y))
            {
                if (!carrier.Variables.ContainsKey(parameters[1]))
                {
                    if (!carrier.IsTest)
                    {
                        showError("Parameters should be numbers");
                    }

                    return false;
                }
            }

            if (x < 0)
            {
                if (!carrier.IsTest)
                {
                    showError("Parameters must be positive");
                }

                return false;
            }
            if (y < 0)
            {
                if (!carrier.IsTest)
                {
                    showError("Parameters must be positive");
                }

                return false;
            }

            return true;
        }

        /// <summary>
        /// Throws an exception with the specified message if validation fails.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <exception cref="IllegalParameterException">Thrown when validation fails.</exception>
        public void showError(string message)
        {
            throw new IllegalParameterException(message);
        }
    }
}
