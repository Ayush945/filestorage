using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Assignment1.ExceptionHandler
{
    /// <summary>
    /// Represents an exception thrown for illegal or invalid parameters.
    /// </summary>
    public class IllegalParameterException:Exception
    {
        private string customMessage;

        /// <summary>
        /// Initializes a new instance of the <see cref="IllegalParameterException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public IllegalParameterException(string message) : base(message)
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
