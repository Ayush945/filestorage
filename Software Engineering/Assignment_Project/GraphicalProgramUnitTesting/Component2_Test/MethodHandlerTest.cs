using Assignment1.Validation;
using Assignment1.Validation.impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.Component2_Test
{
    /// <summary>
    /// Test class for method handler
    /// </summary>
    [TestClass]
    public class MethodHandlerTest
    {
        /// <summary>
        /// Object of ICommandValidator class
        /// </summary>
        private ICommandValidator validator;
        /// <summary>
        /// Initialize the field validator
        /// </summary>
        public MethodHandlerTest()
        {
            validator = new CommandValidatorImpl();
        }
        /// <summary>
        /// Check the parameter of method invoker and method defination
        /// </summary>
        [TestMethod]
        public void checkMethodParameter()
        {
            // Arrange
            string command = "add (1,2,3)";
           
            string mutiText = "method add (a,b,c)\n" +
                "circle 50\n" +
                "endmethod";
            //Act and Assert
            Assert.IsTrue(validator.isMultiCommandValid(command, mutiText));
        }
        /// <summary>
        /// Check the different parameter of method invoker and method defination
        /// </summary>
        [TestMethod]
        public void checkDifferentMethodParameter()
        {
            // Arrange
            string command = "add (1,2)";
            
            string mutiText = "method add (a,b,c)\n" +
                "circle 50\n" +
                "endmethod";
            //Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command, mutiText));
        }
        /// <summary>
        /// Test method invoker
        /// </summary>

        [TestMethod]
        public void checkMethodInvoker()
        {
            // Arrange
            string command = "add (1";
            
            string mutiText = "method add (a,b,c)\n" +
                "circle 50\n" +
                "endmethod";
            //Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command, mutiText));
        }
        /// <summary>
        /// Test method invoker with word as parameter
        /// </summary>

        [TestMethod]
        public void checkMethodInvokerParameter()
        {
            // Arrange
            string command = "add (a,b,c)";
            
            string mutiText = "method add (a,b,c)\n" +
                "circle 50\n" +
                "endmethod";
            //Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command, mutiText));
        }
    }
}
