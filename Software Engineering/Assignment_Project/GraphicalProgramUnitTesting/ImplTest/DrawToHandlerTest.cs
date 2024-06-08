using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test DrawToHandler class
    /// </summary>
    [TestClass]
    public class DrawToHandlerTest
    {
        ICommandValidator validator;
        public DrawToHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test method to check if command drawto is working
        /// </summary>
        [TestMethod]
        public void checkDrawToSyntax()
        {
            string command = "drawto 50,50";
            Assert.IsTrue(validator.isCommandValid(command));

        }

        /// <summary>
        /// Test method to check if no of parameter is correct
        /// </summary>
        [TestMethod]
        public void checkDrawToLength()
        {
            string command = "drawto 1,1,1";
            Assert.IsFalse(validator.isCommandValid(command));
        }
        /// <summary>
        /// Test method to check if the parameter not alphaber
        /// </summary>

        [TestMethod]
        public void checkDrawToParameterInteger()
        {
            string command = "drawto a,a";
            Assert.IsFalse(validator.isCommandValid(command));
        }
        /// <summary>
        /// Test method to check negative parameter
        /// </summary>
        [TestMethod]
        public void checkDrawToNegativeParameter()
        {
            string command = "drawto -50,50";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'drawto' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckDrawToCaseInsensitive()
        {
            // Arrange
            string command = "DraWTO 50,50";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'drawto' command with a decimal radius is valid.
        /// </summary>
        [TestMethod]
        public void CheckDrawToValidWithDecimal()
        {
            // Arrange
            string command = "drawto 50.5,50.5";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }
    }
}
