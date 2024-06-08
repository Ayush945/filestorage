using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Handles the reset command by resetting the drawing position.
    /// </summary>
    public class ResetHandler : ICommandHandler
    {
        private Carrier carrier;
        private string command;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetHandler"/> class.
        /// </summary>
        /// <param name="command">The reset command string.</param>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public ResetHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }

        /// <summary>
        /// Executes the reset command by resetting the drawing position.
        /// </summary>
        public void execute()
        {
            if (validate())
            {
                carrier.PositionX = 0;
                carrier.PositionY = 0;
            }
        }

        /// <summary>
        /// Validates the parameters of the reset command.
        /// </summary>
        /// <returns>True if validation succeeds; otherwise, false.</returns>
        public Boolean validate()
        {
            string[] commandParts = command.Trim().Split(' ');

            if (commandParts.Length != 1)
            {
                if (!carrier.IsTest) { showError("No parameters allowed"); }
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
