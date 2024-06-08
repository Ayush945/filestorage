using Assignment1.Validation;
using Assignment1.Validation.impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.ImplTest
{
    /// <summary>
    /// Test Class to test TriangleHandler class
    /// </summary>
    [TestClass]
    public class TriangleHandlerTest
    {
        ICommandValidator validator;
        /// <summary>
        /// Initialize validator field
        /// </summary>
        public TriangleHandlerTest() 
        {
            validator=new CommandValidatorImpl();
        }
        /// <summary>
        /// Test method to check if command triangle is working
        /// </summary>
        [TestMethod]
        public void checkTriangleSyntax()
        {
            string command = "triangle 50,50";
            Assert.IsTrue(validator.isCommandValid(command));

        }
        /// <summary>
        /// Test method to check for negative parameter
        /// </summary>
        [TestMethod]
        public void checkTriangleNegativeParameter()
        {
            string command = "triangle -50,50";
            Assert.IsFalse(validator.isCommandValid(command));
        }
        /// <summary>
        /// Test method to check for alphabets
        /// </summary>
        [TestMethod]
        public void checkTriangleIntegerParameter()
        {
            string command = "triangle a,a";
            Assert.IsFalse (validator.isCommandValid(command));
        }
        
        /// <summary>
        /// Test method to check if no of parameter is correct
        /// </summary>
        [TestMethod]
        public void checkTriangleParameterLength()
        {
            string command = "triangle 50";
            Assert.IsFalse(validator.isCommandValid(command));
        }
        /// <summary>
        /// Test method to check if the 'triangle' command is case-insensitive.
        /// </summary>
        [TestMethod]
        public void CheckTriangleCaseInsensitive()
        {
            
            string command = "TriAngLe 50,50";
            Assert.IsTrue(validator.isCommandValid(command));
        }

        /// <summary>
        /// Test method to check if the 'triangle' command with a decimal radius is valid.
        /// </summary>
        [TestMethod]
        public void CheckTriangleValidWithDecimal()
        {
            string command = "triangle 50,50";
            Assert.IsTrue(validator.isCommandValid(command));
        }
    }
}
