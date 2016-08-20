﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Exceptions;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorCommandsTests
    {
        [TestMethod]
        public void CalculatorCommandsCanBeInstantiatedWithInputString()
        {
            CalculatorCommands command = new CalculatorCommands("last", new Stack(), new Variables());
            Assert.IsNotNull(command);
        }

        [TestMethod]
        public void CalculatorCommandsWillEvaluateStringsThatAreNotSpecifiedCommands()
        {
            CalculatorCommands command = new CalculatorCommands("1+2", new Stack(), new Variables());
            Assert.AreEqual("3", command.Output);
        }

        [TestMethod]
        [ExpectedException(typeof(InputStringException))]
        public void CalculatorCommandsWillThrowAnExceptionForCompletelyInvalidInputs()
        {
            CalculatorCommands command = new CalculatorCommands("poop", new Stack(), new Variables());
        }
    }
}
