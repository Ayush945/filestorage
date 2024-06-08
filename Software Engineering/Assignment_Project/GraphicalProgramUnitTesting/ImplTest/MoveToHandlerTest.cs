using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test MoveToHandler class
    /// </summary>
    [TestClass]
    public class MoveToHandlerTest
    {
        ICommandValidator validator;
        /// <summary>
        /// Initialize the validator field
        /// </summary>
        public MoveToHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test method to check if command Move to is working
        /// </summary>
        [TestMethod]
        public void checkMoveToSyntax()
        {
            string command = "moveto 50,50";
            Assert.IsTrue(validator.isCommandValid(command));

        }
        /// <summary>
        /// Test method to check for negative parameter
        /// </summary>
        [TestMethod]
        public void checkMoveToNegativeParameter()
        {
            string command = "moveto -50,50";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check for alphabets
        /// </summary>
        [TestMethod]
        public void checkMoveToIntegerParameter()
        {
            string command = "moveto a,a";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if no of parameter is correct
        /// </summary>
        [TestMethod]
        public void checkMoveToLength()
        {
            string command = "moveto 50";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'moveto' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckMoveToCaseInsensitive()
        {
            // Arrange
            string command = "MovETo 50,50";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'moveto' command with a decimal radius is valid.
        /// </summary>
        [TestMethod]
        public void CheckMoveToValidWithDecimal()
        {
            // Arrange
            string command = "moveto 50.5,50.7";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }
    }
}
