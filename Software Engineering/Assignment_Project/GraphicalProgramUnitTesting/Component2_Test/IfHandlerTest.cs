using Assignment1.Validation.impl;
using Assignment1.Validation;
using GraphicalProgramUnitTesting.ImplTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment1.POJO;

namespace GraphicalProgramUnitTesting.Component2_Test
{
    /// <summary>
    /// Test class for If Condition
    /// </summary>
    [TestClass]

    public class IfHandlerTest
    {
        /// <summary>
        /// The command validator used for testing.
        /// </summary>
        ICommandValidator validator;

        /// <summary>
        /// Initializes a new instance of the validator field
        /// </summary>
        public IfHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test to check endif
        /// </summary>
        [TestMethod]
        public void endIfTest()
        {
            // Arrange
            string command =
                "if a < 15\n" +
                "circle 50\n";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command.Trim(),""));
        }
        /// <summary>
        /// Test for first operands as number
        /// </summary>
        [TestMethod]
        public void firstOperandCondition()
        {
            // Arrange
            string command =
                "if 2 < 15\n" +
                "circle 50\n" +
                "endif";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command.Trim(), ""));
        }
        /// <summary>
        /// Test for second operands as word
        /// </summary>
        [TestMethod]
        public void secondOperandCondition()
        {
            // Arrange
            string command =
                "if a < t\n" +
                "circle 50\n" +
                "endif";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command.Trim(), ""));
        }
        /// <summary>
        /// Test for working if condtion
        /// </summary>
        [TestMethod]
        public void workingIfCondition()
        {
            // Arrange
            string command =
                "if a < 15\n"+
                "circle 50\n" +
                "endif";
            // Act and Assert
            Assert.IsTrue(validator.isMultiCommandValid(command.Trim(), ""));
        }
    }
}
