using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test InkPenHandler class
    /// </summary>
    [TestClass]
    public class InkPenHandlerTest
    {
        ICommandValidator validator;
        /// <summary>
        /// Initialize validator field
        /// </summary>
        public InkPenHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test method to check if command pen is working
        /// </summary>
        [TestMethod]
        public void checkPenSyntax()
        {
            string command = "pen red";
            Assert.IsTrue(validator.isCommandValid(command));

        }
        
        /// <summary>
        /// Test method to check if parameter is color or random string
        /// </summary>
        [TestMethod]
        public void checkPenColorParameter()
        {
            string command = "pen gty";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if no of parameter is correct
        /// </summary>
        [TestMethod]
        public void checkPenLength()
        {
            string command = "pen red blue";
            Assert.IsFalse(validator.isCommandValid(command));
        }
        /// <summary>
        /// Test method to check if the parameter is color and not integer
        /// </summary>

        [TestMethod]
        public void checkPenParameterInteger()
        {
            string command = "pen 2";
            Assert.IsFalse(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'pen' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckInkPenCaseInsensitive()
        {
            // Arrange
            string command = "pEn red";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

    }
}
