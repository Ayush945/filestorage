using System;

namespace Assignment1.Validation.impl
{
    /// <summary>
    /// Implementation of the ICommandValidator interface for command validation.
    /// </summary>
    public class CommandValidatorImpl : ICommandValidator
    {
        private CommandParser parser;

        /// <summary>
        /// Initializes a new instance of the CommandValidatorImpl class.
        /// </summary>
        public CommandValidatorImpl()
        {
            parser = new CommandParser();
        }

        /// <summary>
        /// Validates the given command using a command parser.
        /// </summary>
        /// <param name="command">The command to validate.</param>
        /// <returns>True if the command is valid; otherwise, false.</returns>
        public bool isCommandValid(string command)
        {
            command = command.ToLower();
            if (parser.checkSingleLineCommand(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Validates the given command using a command parser for multi command
        /// </summary>
        /// <param name="multiCommand">The command to validate.</param>
        /// <param name="text">Whole Command</param>
        /// <returns>True if the command is valid; otherwise, false.</returns>
        public bool isMultiCommandValid(string multiCommand,string text)
        {
            multiCommand = multiCommand.ToLower();
            if (parser.checkMultiLineCommand(multiCommand,text))
            {
                return true;
            }
            else { return false; }
        }
    }
}
