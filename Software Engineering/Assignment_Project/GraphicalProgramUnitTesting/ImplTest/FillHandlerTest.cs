using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test FillHandler class
    /// </summary>
    [TestClass]
    public class FillHandlerTest
    {
            ICommandValidator validator;
            public FillHandlerTest()
            {
                validator = new CommandValidatorImpl();
            }

            /// <summary>
            /// Test method to check if command Fill is working
            /// </summary>
            [TestMethod]
            public void checkFillSyntax()
            {
                string command = "fill on";
                Assert.IsTrue(validator.isCommandValid(command));

            }

            /// <summary>
            /// Test method to check if no of parameter is correct
            /// </summary>
            [TestMethod]
            public void checkFillLength()
            {
                string command = "fill on off";
                Assert.IsFalse(validator.isCommandValid(command));
            }
            /// <summary>
            /// Test method to check if the parameter not integer
            /// </summary>

            [TestMethod]
            public void checkFillParameterInteger()
            {
                string command = "fill 2";
                Assert.IsFalse(validator.isCommandValid(command));
            }

        /// <summary>
        /// Test method to check if the 'fill' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckFillCaseInsensitive()
        {
            // Arrange
            string command = "FiLL on";

            // Act and Assert
            Assert.IsTrue(validator.isCommandValid(command));
        }

        
    }
}
