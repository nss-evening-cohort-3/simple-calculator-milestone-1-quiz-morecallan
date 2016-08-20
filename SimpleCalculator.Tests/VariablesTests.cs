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
        public void VariablesAreCreatedWhenTheyMatchTheCorrectFormat()
        {
            Variables newVar = new Variables();
            Assert.IsTrue(newVar.VariablePatternMath("x=90"));
        }

        [TestMethod]
        public void VariablesAreNotCreatedWhenTheyDoNotMatchTheCorrectFormat()
        {
            Variables newVar = new Variables();
            Assert.IsFalse(newVar.VariablePatternMath("x="));
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

        [TestMethod]
        public void VariablesAreStoredAsLowerCase()
        {
            Variables newVar = new Variables();
            newVar.VariableCreation("G=4");
            Assert.AreEqual(4, newVar.VariablesList["g"]);
        }

        [TestMethod]
        public void MultipleVariablesCanBeStored()
        {
            Variables newVar = new Variables();
            newVar.VariableCreation("G=4");
            newVar.VariableCreation("f=99");
            newVar.VariableCreation("x=-22");
            Assert.AreEqual(4, newVar.VariablesList["g"]);
            Assert.AreEqual(99, newVar.VariablesList["f"]);
            Assert.AreEqual(-22, newVar.VariablesList["x"]);
        }

        [TestMethod]
        public void InputStringsContainingAVariableWillBeReturnedAsAValidEvaluableString()
        {
            Variables newVar = new Variables();
            newVar.VariableCreation("G=4");
            newVar.VariableCreation("f=99");
            string convertedString = newVar.ConvertInputString("f+g");
            Assert.AreEqual("99+4", convertedString);
        }

        [TestMethod]
        public void VariablesListCanBeCheckedForSingleTerm()
        {
            Variables newVar = new Variables();
            newVar.VariableCreation("G=4");
            Assert.IsTrue(newVar.CheckDictionary("g"));
            Assert.IsFalse(newVar.CheckDictionary("h"));
        }
    }
}
