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
            Assert.Fail();
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForAddition()
        {
            Evaluate my_evaluate = new Evaluate("1+2");
            Assert.AreEqual(3, my_evaluate.Answer);
        }

    }
}
