using Assignment1.Validation.impl;
using Assignment1.Validation;
using GraphicalProgramUnitTesting.ImplTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.Component2_Test
{
    /// <summary>
    /// Test class for variable assignment
    /// </summary>
    [TestClass]
    
    public class VariableAssignmentTest
    {
        /// <summary>
        /// The command validator used for testing.
        /// </summary>
        ICommandValidator validator;

        /// <summary>
        /// Initializes a new instance of the validator field.
        /// </summary>
        public VariableAssignmentTest()
        {
            validator = new CommandValidatorImpl();
        }
        /// <summary>
        /// Test method for testing positive number assignment
        /// </summary>
        [TestMethod]
        public void positiveNumberAssignment()
        {
            // Arrange
            string command = "a=2";

            // Act and Assert
            Assert.IsTrue(validator.isMultiCommandValid(command,""));

        }
        /// <summary>
        /// Test method for testing word assignment
        /// </summary>
        [TestMethod]
        public void wordAssignment()
        {
            // Arrange
            string command = "a=a";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command, ""));
        }
        /// <summary>
        /// Test for word addition
        /// </summary>
        [TestMethod]
        public void wordAddition()
        {
            // Arrange
            string command = "a=a+a";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command,""));
        }
        /// <summary>
        /// Test for word and number addition
        /// </summary>
        [TestMethod]
        public void wordNumberAddition()
        {
            // Arrange
            string command = "a=a+2";

            // Act and Assert
            Assert.IsTrue(validator.isMultiCommandValid(command,""));
        }

        /// <summary>
        /// Test for only one operand with sign
        /// </summary>
        [TestMethod]
        public void operandSignTest()
        {
            // Arrange
            string command = "a=-2";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command,""));
        }

    }
}
