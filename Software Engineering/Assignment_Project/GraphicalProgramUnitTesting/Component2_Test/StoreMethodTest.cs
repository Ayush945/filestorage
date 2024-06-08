using Assignment1.Validation;
using Assignment1.Validation.impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GraphicalProgramUnitTesting.Component2_Test
{
    /// <summary>
    /// Test class for method store
    /// </summary>
    [TestClass]
    public class StoreMethodTest
    {
        /// <summary>
        /// Object of ICommandValidator class
        /// </summary>
        private ICommandValidator validator;
        /// <summary>
        /// Initialize the field validator
        /// </summary>
        public StoreMethodTest()
        {
            validator=new CommandValidatorImpl();
        }
        /// <summary>
        /// Test method Defination
        /// </summary>
        [TestMethod]
        public void testMethodDefination()
        {
            //Arrange
            string command = "method add";
            string multiText = "method add ()\n" +
                "circle 50\n" +
                "endmethod";
            //Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command, multiText));
        }
        /// <summary>
        /// Test numbers as parameter
        /// </summary>
        [TestMethod]
        public void testMethodParameter()
        {
            //Arrange
            string command = "method add(1,2,3)";
            string multiText = "method add (1,2,3)\n" +
                "circle 50\n" +
                "endmethod";
            //Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command, multiText));
        }
        /// <summary>
        /// Test proper method parameter
        /// </summary>
        [TestMethod]
        public void testProperMethodParamerter()
        {
            //Arrange
            string command = "method add (a,b)";
            
            string multiText = "method add (a,b)\n" +
                "circle 50\n" +
                "endmethod";
            //Act and Assert
            Assert.IsTrue(validator.isMultiCommandValid(command, multiText));
        }
        /// <summary>
        /// Test method without endmethod
        /// </summary>
        [TestMethod]
        public void testMethodBody()
        {
            // Arrange
            string command = "method add ()";
            
            string multiText = "method add ()\n" +
                "circle 50";
            //Act and Assert
            Assert.IsFalse(validator.isMultiCommandValid(command, multiText));
        }
    }
}
