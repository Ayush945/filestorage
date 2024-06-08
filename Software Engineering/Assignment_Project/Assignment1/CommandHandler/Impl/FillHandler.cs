using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;
using System.Windows.Forms;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Handles the fill command by toggling the filling state for drawing shapes.
    /// </summary>
    public class FillHandler : ICommandHandler
    {
        private String command;
        private Carrier carrier;

        /// <summary>
        /// Initializes a new instance of the <see cref="FillHandler"/> class.
        /// </summary>
        /// <param name="command">The fill command string.</param>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public FillHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }

        /// <summary>
        /// Executes the fill command by toggling the filling state for drawing shapes.
        /// </summary>
        public void execute()
        {
            if (validate())
            {
                string[] commandParts = command.Split(' ');
                if (commandParts[1].Trim().Equals("on"))
                {
                    carrier.IsFilled = true;
                }
                else
                {
                    carrier.IsFilled = false;
                }
            }
        }

        /// <summary>
        /// Validates the parameters of the fill command.
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
                if(!carrier.IsTest)
                {
                    showError("Wrong number of parameters");
                }
                return false;
            }

            if (!(commandParts[1].Trim().Equals("on", StringComparison.OrdinalIgnoreCase) || commandParts[1].Trim().Equals("off", StringComparison.OrdinalIgnoreCase)))
            {
                if (!carrier.IsTest)
                {
                    showError("Parameter must be 'on' or 'off'");
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
