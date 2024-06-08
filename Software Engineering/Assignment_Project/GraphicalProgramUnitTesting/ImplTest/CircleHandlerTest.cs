using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test the functionality of the CircleHandler class.
    /// </summary>
    [TestClass]
    public class CircleHandlerTest
    {
        /// <summary>
        /// The command validator used for testing.
        /// </summary>
        ICommandValidator validator;

        /// <summary>
        /// Initializes a new instance of the validator class.
        /// </summary>
        public CircleHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test method to check if the 'circle' command syntax is valid.
        /// </summary>
        [TestMethod]
        public void CheckCircleSyntax()
        {
            // Arrange
            string command = "circle 50";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check for a positive parameter in the 'circle' command.
        /// </summary>
        [TestMethod]
        public void CheckCirclePositiveParameter()
        {
            // Arrange
            string command = "circle 50";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check for a negative parameter in the 'circle' command.
        /// </summary>
        [TestMethod]
        public void CheckCircleNegativeParameter()
        {
            // Arrange
            string command = "circle -50";

            // Act and Assert
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check for non-integer parameter in the 'circle' command.
        /// </summary>
        [TestMethod]
        public void CheckCircleIntegerParameter()
        {
            // Arrange
            string command = "circle a";

            // Act and Assert
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the number of parameters in the 'circle' command is correct.
        /// </summary>
        [TestMethod]
        public void CheckCircleLength()
        {
            // Arrange
            string command = "circle 40,40";

            // Act and Assert
            Assert.IsFalse(validator.isCommandValid(command));
        }
        /// <summary>
        /// Test method to check if the 'circle' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckCircleCaseInsensitive()
        {
            // Arrange
            string command = "CiRcLe 50";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'circle' command with a decimal radius is valid.
        /// </summary>
        [TestMethod]
        public void CheckCircleValidWithDecimal()
        {
            // Arrange
            string command = "circle 50.5";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

    }
}
