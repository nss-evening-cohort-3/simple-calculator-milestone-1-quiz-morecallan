﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Exceptions;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        //Prove you can extract the terms of the expression.
        public void ExpressionContainsTwoTermProperties()
        {
            Expression my_expression = new Expression();
            Assert.IsNotNull(my_expression.Term1);
            Assert.IsNotNull(my_expression.Term2);
        }

        [TestMethod]
        //Prove you can extract the terms of the expression.
        public void TwoTermsCanBeExtractedFromExpression()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("1+3");
            Assert.AreEqual(1, my_expression.Term1);
            Assert.AreEqual(3, my_expression.Term2);
        }

        [TestMethod]
        //Prove you can extract the terms of the expression.
        public void TermsCanBeDoubleDigit()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("41+3900");
            Assert.AreEqual(41, my_expression.Term1);
            Assert.AreEqual(3900, my_expression.Term2);
        }

        [TestMethod]
        //Prove you can extract the terms of the expression.
        public void TermsCanBeNegative()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("-41+-6");
            Assert.AreEqual(-41, my_expression.Term1);
            Assert.AreEqual(-6, my_expression.Term2);
        }

        [TestMethod]
        [ExpectedException(typeof(InputStringException))]
        //Prove you can extract the terms of the expression.
        public void InvalidTermsThrowException()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("g+3");
        }

        [TestMethod]
        //Prove you can extract the operation embedded in the expression.
        public void OperationCanBeExtractedFromExpression()
        {
            Expression my_add_expression = new Expression();
            my_add_expression.ParseStringIntoTermsAndOperation("1+2");

            Expression my_divide_expression = new Expression();
            my_divide_expression.ParseStringIntoTermsAndOperation("6/3");

            Assert.AreEqual("+", my_add_expression.Operation);
            Assert.AreEqual("/", my_divide_expression.Operation);
        }

        [TestMethod]
        [ExpectedException(typeof(InputStringException))]
        //Prove you can extract the operation embedded in the expression.
        public void InvalidOperationThrowsException()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("1!3");
        }

        [TestMethod]
        [ExpectedException(typeof(InputStringException))]
        //Prove you can extract the operation embedded in the expression.
        public void InvalidCommandThrowsException()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("5");
        }

        [TestMethod]
        [ExpectedException(typeof(InputStringException))]
        //Prove you can extract the operation embedded in the expression.
        public void IncompleteExpressionsThrowAnException()
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("5+");
        }
    }
}
