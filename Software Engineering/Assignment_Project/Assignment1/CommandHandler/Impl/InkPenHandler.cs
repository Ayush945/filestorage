using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;
using System.Drawing;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Handles the pen command by setting the drawing color.
    /// </summary>
    public class InkPenHandler : ICommandHandler
    {
        private string command;
        private Carrier carrier;

        /// <summary>
        /// Initializes a new instance of the <see cref="InkPenHandler"/> class.
        /// </summary>
        /// <param name="command">The pen command string.</param>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public InkPenHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }

        /// <summary>
        /// Executes the pen command by setting the drawing color.
        /// </summary>
        public void execute()
        {
            if (validate())
            {
                string[] commandParts = command.Split(' ');
                ColorConverter converter = new ColorConverter();

                carrier.Color = (Color)converter.ConvertFromString(commandParts[1]);
            }
        }

        /// <summary>
        /// Validates the parameters of the pen command.
        /// </summary>
        /// <returns>True if validation succeeds; otherwise, false.</returns>
        public Boolean validate()
        {
            string[] commandParts = command.Split(' ');
            if (commandParts[1].Split(',').Length > 1)
            {
                return false;
            }
            if (commandParts.Length != 2)
            {
                if (!carrier.IsTest)
                {
                    showError("Wrong number of parameters");
                }
                return false;
            }

            if (!isColor(commandParts[1]))
            {
                if (!carrier.IsTest)
                {
                    showError("Parameter must be a color");
                }
                return false;
            }

            if (float.TryParse(commandParts[1], out float value))
            {
                if(!carrier.IsTest) { showError("Parameter can't be a number"); }
                
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

        /// <summary>
        /// Checks if the given string represents a valid color.
        /// </summary>
        /// <param name="color">The string representation of a color.</param>
        /// <returns>True if it's a valid color; otherwise, false.</returns>
        public Boolean isColor(string color)
        {
            try
            {
                ColorConverter converter = new ColorConverter();
                converter.ConvertFromString(color);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
