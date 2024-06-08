using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test ResetHandler class
    /// </summary>
    [TestClass]
    public class ResetHandlerTest
    {
        ICommandValidator validator;
        /// <summary>
        /// Initialize validator field
        /// </summary>
        public ResetHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test method to check if command reset is working
        /// </summary>
        [TestMethod]
        public void checkResetSyntax()
        {
            string command = "reset";
            Assert.IsTrue(validator.isCommandValid(command));

        }
        /// <summary>
        /// Test method to check if no of parameter is correct
        /// </summary>
        [TestMethod]
        public void checkResetParameterLength()
        {
            string command = "reset 1";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'reset' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckResetCaseInsensitive()
        {
            // Arrange
            string command = "ReSeT";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

    }
}
