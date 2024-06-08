using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test ClearHandler class
    /// </summary>
    [TestClass]
    public class ClearHandlerTest
    {
        ICommandValidator validator;
        /// <summary>
        /// Constructor and initialization of validator field
        /// </summary>
        public ClearHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test method to check if command clear is working
        /// </summary>
        [TestMethod]
        public void checkClearSyntax()
        {
            string command = "clear";
            Assert.IsTrue(validator.isCommandValid(command));

        }
        /// <summary>
        /// Test method to check if no of parameter is correct
        /// </summary>
        /// 
        [TestMethod]
        public void checkClearParameterLength()
        {
            string command = "clear 1";
            Assert.IsFalse(validator.isCommandValid(command));
        }
        /// <summary>
        /// Test method to check if the 'clear' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckClearCaseInsensitive()
        {
            // Arrange
            string command = "CleaR";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

       
    }
}
