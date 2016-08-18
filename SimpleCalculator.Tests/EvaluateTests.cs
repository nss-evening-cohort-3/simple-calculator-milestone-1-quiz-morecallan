using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Exceptions;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EvaluateCanBeInstantiatedWithInputString()
        {
            Evaluate my_evaluate = new Evaluate("1+2");
            Assert.IsNotNull(my_evaluate);
        }

        [TestMethod]
        [ExpectedException(typeof(InputStringException))]
        public void ExceptionIsThrownIfEvaluateIsConstructedWithInvalidString()
        {
            Evaluate my_evaluate = new Evaluate("+2");
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForAddition()
        {
            Evaluate my_evaluate = new Evaluate("1+2");
            Assert.AreEqual(3, my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForSubtraction()
        {
            Evaluate my_evaluate = new Evaluate("74 - 5");
            Assert.AreEqual(69, my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForDivision()
        {
            Evaluate my_evaluate = new Evaluate("30/2");
            Assert.AreEqual(15, my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForMultiplication()
        {
            Evaluate my_evaluate = new Evaluate("4*90");
            Assert.AreEqual(360, my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForModulo()
        {
            Evaluate my_evaluate = new Evaluate("20%2");
            Assert.AreEqual(0, my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanHandleNegativeInputs()
        {
            Evaluate my_evaluate = new Evaluate("-30+15");
            Assert.AreEqual(-15, my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanHandleNegativeOnBothSides()
        {
            Evaluate my_evaluate = new Evaluate("-30+-15");
            Assert.AreEqual(-45, my_evaluate.Answer);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void EvaluateCantTouchThis()
        {
            Evaluate my_evaluate = new Evaluate("30/0");
        }
    }
}
