using Assignment1.ExceptionHandler;
using Assignment1.POJO;
using System;
using System.Windows.Forms;

namespace Assignment1.CommandHandler.Impl
{
    /// <summary>
    /// Handles the moveto command by updating the drawing position.
    /// </summary>
    public class MoveToHandler : ICommandHandler
    {
        private string command;
        private Carrier carrier;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveToHandler"/> class.
        /// </summary>
        /// <param name="command">The moveto command string.</param>
        /// <param name="carrier">The carrier object containing drawing information.</param>
        public MoveToHandler(string command, Carrier carrier)
        {
            this.command = command;
            this.carrier = carrier;
        }

        /// <summary>
        /// Executes the moveto command by updating the drawing position.
        /// </summary>
        public void execute()
        {
            string[] commandParts = command.Trim().Split(' ');

            if (validate())
            {
                string[] parameters = commandParts[1].Split(',');
                
                string key1 = parameters[0].Trim();
                string key2 = parameters[1].Trim();
                
                float x, y;
                
                bool param1 = carrier.Variables.ContainsKey(key1);
                bool param2 = carrier.Variables.ContainsKey(key2);

                if (param1)
                {
                    x = carrier.Variables[key1];

                }
                else
                {
                    x = float.Parse(parameters[0]);
                }
                if (param2)
                {
                    y = carrier.Variables[key2];
                }
                else
                {

                    y = float.Parse(parameters[1]);
                }

                carrier.PositionX = x;
                carrier.PositionY = y;
            }
        }

        /// <summary>
        /// Validates the parameters of the moveto command.
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
