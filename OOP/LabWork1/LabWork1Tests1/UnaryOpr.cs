using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabWork1;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork1.Tests
{
    [TestClass()]
    public class UnaryOpr
    {
        [TestMethod()]
        public void Evaluate_plus20_20return()
        {
            // arrange
            double x = 20;
            string expr = $"+{x}";
            double expected = 20;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Evaluate_minus20_minus20return()
        {
            // arrange
             double x = 20;
            string expr = $"-{x}";
            double expected = -20;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Evaluate_plusminus20_minus20return()
        {
            // arrange
            double x = 20;
            string expr = $"+-{x}";
            double expected = -20;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Evaluate_inc20_21return()
        {
            // arrange
            double x = 20;
            string expr = $"++{x}";
            double expected = 21;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Evaluate_dec20_19return()
        {
            // arrange
            double x = 20;
            string expr = $"--{x}";
            double expected = 19;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Evaluate_dec3exp4_16return()
        {
            // arrange
            double x = 3;
            string expr = $"--{x}^4";
            double expected = 16;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Evaluate_minus3plus4_1return()
        {
            // arrange
            double x = 3;
            string expr = $"-{x}+4";
            double expected = 1;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }


    }
    [TestClass()]
    public class ParenthesizedOpr
    {
        [TestMethod()]
        public void Evaluate_p2and3pExp2_25return()
        {
            // arrange
            double x = 2;
            double y = 3;
            double z = 2;
            string expr = $"({x}+{y})^{z}";
            double expected = 25;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]

        public void Evaluate_minusp2and3p_minus5return()
        {
            // arrange
            double x = 2;
            double y = 3;
            string expr = $"-({x}+{y})";
            double expected = -5;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Evaluate_expWithAllOpr_25return()
        {
            // arrange
            double x = 2;
            double y = 3;
            double z = 2;
            string expr = $"++(({x}+{y})^{z}%{y}/{x})";
            double expected = 1;

            // act
            var result = Calculator.Evaluate(expr);

            // assert
            Assert.AreEqual(expected, result);
        }


    }
}