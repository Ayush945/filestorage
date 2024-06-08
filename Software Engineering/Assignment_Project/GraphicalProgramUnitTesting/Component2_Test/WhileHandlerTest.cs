using Assignment1.Validation.impl;
using Assignment1.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.Component2_Test
{
    /// <summary>
    /// Test for while condition
    /// </summary>
    [TestClass]
    public class WhileHandlerTest
    {
        /// <summary>
        /// The command validator used for testing.
        /// </summary>
        ICommandValidator validator;

        /// <summary>
        /// Initializes a new instance of the validator field
        /// </summary>
        public WhileHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }

        /// <summary>
        /// Test to check endloop
        /// </summary>
        [TestMethod]
        public void endLoopTest()
        {
            // Arrange
            string command =
                "while a < 15\n" +
                "circle 50\n";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command.Trim(), ""));
        }
        /// <summary>
        /// Test for first operands as number
        /// </summary>
        [TestMethod]
        public void firstOperandCondition()
        {
            // Arrange
            string command =
                "while 2 < 15\n" +
                "circle 50\n" +
                "endloop";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command.Trim(),""));
        }
        /// <summary>
        /// Test for second operands as word
        /// </summary>
        [TestMethod]
        public void secondOperandCondition()
        {
            // Arrange
            string command =
                "while a < t\n" +
                "circle 50\n" +
                "endloop";

            // Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command.Trim(), ""));
        }
        /// <summary>
        /// Test for working while condtion
        /// </summary>
        [TestMethod]
        public void workingWhileCondition()
        {
            // Arrange
            string command =
                "while a < 5\n" +
                "circle 50\n" +
                "endloop";
            // Act and Assert
            Assert.IsTrue(validator.isMultiCommandValid(command.Trim(),""));
        }
    }
}
