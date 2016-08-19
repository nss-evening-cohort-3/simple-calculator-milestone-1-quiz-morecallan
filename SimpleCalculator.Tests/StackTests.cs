using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackCanBeInstantiatedWithUsersValidCommand()
        {
            Stack stack = new Stack();
            Assert.IsNotNull(stack);
        }

        [TestMethod]
        public void StackRetainsLastCommand()
        {
            Stack stack = new Stack();
            stack.setStack("1+2");
            Assert.AreEqual("1+2", stack.LastCommand);
        }

        [TestMethod]
        public void StackReturnsLastAnswer()
        {
            Stack stack = new Stack();
            stack.setStack("1+2");
            Assert.AreEqual(3, stack.LastAnswer);
        }
    }
}
