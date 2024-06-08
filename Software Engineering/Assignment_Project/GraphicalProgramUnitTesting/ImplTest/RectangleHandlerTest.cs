using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test RectangleHandler class
    /// </summary>
    [TestClass]
    public class RectangleHandlerTest
    {
        ICommandValidator validator;
        /// <summary>
        /// Initialize validator field
        /// </summary>
        public RectangleHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test method to check if command rectangle is working
        /// </summary>
        [TestMethod]
        public void checkRectangleSyntax()
        {
            string command = "rectangle 50,50";
            Assert.IsTrue(validator.isCommandValid(command));

        }
        /// <summary>
        /// Test method to check for negative parameter
        /// </summary>
        [TestMethod]
        public void checkRectangleNegativeParameter()
        {
            string command = "rectangle -50,50";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check for alphabets
        /// </summary>
        [TestMethod]
        public void checkRectangleIntegerParameter()
        {
            string command = "rectangle a,a";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if no of parameter is correct
        /// </summary>
        [TestMethod]
        public void checkRectangleLength()
        {
            string command = "rectangle 50";
            Assert.IsFalse(validator.isCommandValid(command));
        }
        /// <summary>
        /// Test method to check if the 'rectangle' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckRectangleCaseInsensitive()
        {
            // Arrange
            string command = "RecTanGle 50,50";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'rectangle' command with a decimal radius is valid.
        /// </summary>
        [TestMethod]
        public void CheckRectangleValidWithDecimal()
        {
            // Arrange
            string command = "rectangle 50.5,50.5";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }
    }
}
