using System;

namespace Assignment1.Validation
{
    /// <summary>
    /// Interface for validating commands.
    /// </summary>
    public interface ICommandValidator
    {
        /// <summary>
        /// Validates the given command.
        /// </summary>
        /// <param name="command">The command to validate.</param>
        /// <returns>True if the command is valid; otherwise, false.</returns>
        bool isCommandValid(string command);
        /// <summary>
        /// Validates the given multi command.
        /// </summary>
        /// <param name="multiCommand"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        bool isMultiCommandValid(string multiCommand,string text);
    }
}
