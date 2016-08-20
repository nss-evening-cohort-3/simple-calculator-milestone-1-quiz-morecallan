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
            Evaluate my_evaluate = new Evaluate();
            Assert.IsNotNull(my_evaluate);
        }

        [TestMethod]
        public void ErrorIsDisplayedIfEvaluateIsConstructedWithInvalidString()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("+2", new Variables());
            Assert.AreEqual("Oopsie Daisy. Please enter a valid command.", my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForAddition()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("1+2", new Variables());
            Assert.AreEqual("3", my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForSubtraction()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("74 - 5", new Variables());
            Assert.AreEqual("69", my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForDivision()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("30/2", new Variables());
            Assert.AreEqual("15", my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForMultiplication()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("4*90", new Variables());
            Assert.AreEqual("360", my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanProduceExpectedResultForModulo()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("20%2", new Variables());
            Assert.AreEqual("0", my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanHandleNegativeInputs()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("-30+15", new Variables());
            Assert.AreEqual("-15", my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCanHandleNegativeOnBothSides()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("-30+-15", new Variables());
            Assert.AreEqual("-45", my_evaluate.Answer);
        }

        [TestMethod]
        public void EvaluateCantTouchThis()
        {
            Evaluate my_evaluate = new Evaluate();
            my_evaluate.Evaluation("30/0", new Variables());
            Assert.AreEqual("Oopsie Daisy. Please enter a valid command.", my_evaluate.Answer);

        }
    }
}
