using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System.Drawing;
using System;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Handles the triangle command by drawing a triangle on the panel.
    /// </summary>
    public class TriangleHandler : ICommandHandler
    {
        private string command;
        private Carrier carrier;

        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleHandler"/> class.
        /// </summary>
        /// <param name="command">The triangle command string.</param>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public TriangleHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }

        /// <summary>
        /// Executes the triangle command by drawing a triangle on the panel.
        /// </summary>
        public void execute()
        {
            if (validate())
            {
                string[] commandParts = command.Split(' ');
                string[] parameters = commandParts[1].Trim().Split(',');

                int posX = (int)carrier.PositionX;
                int posY = (int)carrier.PositionY;

                int height;
                int triangleBase;

                string key1 = parameters[0].Trim();
                string key2 = parameters[1].Trim();

                bool param1 = carrier.Variables.ContainsKey(key1);
                bool param2 = carrier.Variables.ContainsKey(key2);
                if (param1 && param2)
                {
                    height = (int)carrier.Variables[key1];
                    
                }
                else
                {
                    height = int.Parse(parameters[0]);
                }
                if (param2)
                {
                    triangleBase = (int)carrier.Variables[key2];
                }
                else
                {
                    triangleBase = int.Parse(parameters[1]);
                }

                Pen pen = new Pen(carrier.Color);

                Point point1 = new Point(posX, posY);
                Point point2 = new Point(posX + triangleBase, posY);
                Point point3 = new Point(posX + triangleBase / 2, posY + height);

                if (carrier.IsFilled)
                {
                    SolidBrush brush = new SolidBrush(carrier.Color);
                    carrier.Graphics.FillPolygon(brush, new Point[] { point1, point2, point3 });
                }

                carrier.Graphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
            }
        }

        /// <summary>
        /// Validates the parameters of the triangle command.
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
