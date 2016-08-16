using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        //Prove you can extract the terms of the expression.
        public void twoTermsCanBeExtractedFromExpression()
        {
            Expression my_expression = new Expression();

        }

        [TestMethod]
        //Prove you can extract the operation embedded in the expression.
        public void operationCanBeExtractedFromExpression()
        {
        }
    }
}
