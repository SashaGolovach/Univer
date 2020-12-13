using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabWork1;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork1.Tests
{
    [TestClass()]
    public class BinaryOpr
    {
        [TestMethod()]
        public void Div_10and3_3Return()
        {
            // arrange
            double x = 10;
            double y = 3;
            string expr = $"{x} / {y}";
            double expected = 3;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Mod_28and5_3Return()
        {
            // arrange
            double x = 28;
            double y = 5;
            string expr = $"{x} % {y}";
            double expected = 3;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Exp_3and2_9Return()
        {
            // arrange
            double x = 3;
            double y = 2;
            string expr = $"{x} ^ {y}";
            double expected = 9;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Plus_3and2_5Return()
        {
            // arrange
            double x = 3;
            double y = 2;
            string expr = $"{x} + {y}";
            double expected = 5;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Minus_7and2_5Return()
        {
            // arrange
            double x = 7;
            double y = 2;
            string expr = $"{x} - {y}";
            double expected = 5;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }

    }
}