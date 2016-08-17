using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Exceptions;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        //Prove you can extract the terms of the expression.
        public void expressionContainsTwoTermProperties()
        {
            Expression my_expression = new Expression();
            Assert.IsNotNull(my_expression.Term1);
            Assert.IsNotNull(my_expression.Term2);
        }

        [TestMethod]
        //Prove you can extract the terms of the expression.
        public void twoTermsCanBeExtractedFromExpression()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("1+3");
            Assert.AreEqual(1, my_expression.Term1);
            Assert.AreEqual(3, my_expression.Term2);
        }

        [TestMethod]
        [ExpectedException(typeof(InputStringException))]
        //Prove you can extract the terms of the expression.
        public void invalidTermsThrowException()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("g+3");
        }

        [TestMethod]
        //Prove you can extract the operation embedded in the expression.
        public void operationCanBeExtractedFromExpression()
        {
        }
    }
}
