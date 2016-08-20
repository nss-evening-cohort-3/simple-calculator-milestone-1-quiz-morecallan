using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Exceptions;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class VariablesTests
    {
        [TestMethod]
        public void VariablesCanBeInstantiated()
        {
            Variables newVar = new Variables();
            Assert.IsNotNull(newVar);
        }

        [TestMethod]
        [ExpectedException(typeof(InputStringException))]
        //Prove you can extract the terms of the expression.
        public void InvalidVariableInputThrowsException()
        {
            Variables newVar = new Variables();
            newVar.VariableCreation("7=3");
        }

        [TestMethod]
        public void NewVariablesWillBeAddedToTheDictionary()
        {
            Variables newVar = new Variables();
            newVar.VariableCreation("g=4");
            Assert.AreEqual(4, newVar.VariablesList["g"]);
        }
    }
}
