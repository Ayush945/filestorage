using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CommandHandler
{
    /// <summary>
    /// Defines the base interface for all command handlers, providing methods for execution, validation, and error handling.
    /// </summary>
    public interface ICommandHandler
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        void execute();

        /// <summary>
        /// Validates the command.
        /// </summary>
        /// <returns>True if the command is valid; otherwise, false.</returns>
        Boolean validate();

        /// <summary>
        /// Throws an exception with the specified message.
        /// </summary>
        /// <param name="message">The message to include in the exception.</param>
        void showError(string message);
    }
}
