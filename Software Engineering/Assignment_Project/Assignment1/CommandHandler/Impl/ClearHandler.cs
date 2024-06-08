using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Handles the clear command by clearing the drawing panel.
    /// </summary>
    public class ClearHandler : ICommandHandler
    {
        private string command;
        private Carrier carrier;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearHandler"/> class.
        /// </summary>
        /// <param name="command">The clear command string.</param>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public ClearHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }

        /// <summary>
        /// Executes the clear command by clearing the drawing panel.
        /// </summary>
        public void execute()
        {
            if (validate())
            {
                carrier.Graphics.Clear(carrier.Panel.BackColor);
            }
        }

        /// <summary>
        /// Validates the parameters of the clear command.
        /// </summary>
        /// <returns>True if validation succeeds; otherwise, false.</returns>
        public Boolean validate()
        {
            string[] commandParts = command.Trim().Split(' ');

            if (commandParts.Length != 1)
            {
                if (!carrier.IsTest)
                {
                    showError("No parameters allowed");
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
