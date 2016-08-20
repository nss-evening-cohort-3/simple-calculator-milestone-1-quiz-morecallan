using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Exceptions;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorCommandsTests
    {
        [TestMethod]
        public void CalculatorCommandsCanBeInstantiated()
        {
            CalculatorCommands command = new CalculatorCommands();
            Assert.IsNotNull(command);
        }

        [TestMethod]
        public void CalculatorCommandsWillEvaluateStringsThatAreNotSpecifiedCommands()
        {
            CalculatorCommands command = new CalculatorCommands("1+2", new Stack(), new Variables());
            Assert.AreEqual("3", command.Output);
        }

        [TestMethod]
        public void CalculatorCommandsWillNotEvaluateCompletelyInvalidInputs()
        {
            CalculatorCommands command = new CalculatorCommands("poop", new Stack(), new Variables());
            Assert.AreEqual("Oopsie Daisy. Please enter a valid command.", command.Output);
        }
    }
}
