using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.ExceptionHandler
{
    internal class IllegalOperatorException:Exception
    {
        private string customMessage;
        /// <summary>
        /// Initializes a new instance of the <see cref="IllegalOperatorException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public IllegalOperatorException(string message) : base(message)
        {
            customMessage = message;
        }

        /// <summary>
        /// Gets or sets the custom message associated with the exception.
        /// </summary>
        public string CustomMessage
        {
            get => customMessage;
            set => customMessage = value;
        }
    }
}
