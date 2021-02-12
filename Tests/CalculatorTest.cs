using NUnit.Framework;
using Services;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Initialize a shared instance of the calculator service here.
        }

        [Test]
        public void AddNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyNumbersWithNoInput()
        {
            Calculator cal = new Calculator();

            var ex = Assert.Throws<Exception>(() => cal.Multiply());
        }
        
        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            Calculator cal = new Calculator();

            double[] numList = { 2, 2 };

            var result = cal.Multiply(numList);

            Assert.IsTrue(4 == result);

        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            Calculator cal = new Calculator();

            double[] numList = { -2, -2 };

            var result = cal.Multiply(numList);

            Assert.IsTrue(-4 == result);
        }

        [Test]
        public void MultiplyThreePositiveNumbers()
        {
            Calculator cal = new Calculator();

            double[] numList = { 2, 2, 1 };

            var result = cal.Multiply(numList);

            Assert.IsTrue(4 == result);
        }

        [Test]
        public void MultiplyThreeNegativeNumbers()
        {
            Calculator cal = new Calculator();

            double[] numList = { -2, -2, -1 };

            var result = cal.Multiply(numList);

            Assert.IsTrue(-4 == result);
        }

        [Test]
        public void DivideNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoNumbersWithZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideThreeNumbersWithZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfFive()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOf200()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfNegativeNumber()
        {
            Assert.Inconclusive("Test not fully implemented");
        }
    }
}