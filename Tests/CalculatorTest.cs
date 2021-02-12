using System;
using System.Diagnostics;
using NUnit.Framework;
using Services;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Initialize a shared instance of the calculator service here.
            Calculator calc = new Calculator();
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
            Assert.Inconclusive("Test not fully implemented");
        }
        
        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
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
            Calculator calc = new Calculator();
            double result = calc.Factorial(5);

            Assert.AreEqual(120, result);
        }

        [Test]
        public void FactorialOf200()
        {
            Calculator calc = new Calculator();
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => calc.Factorial(200));

            Assert.AreEqual("Factorial over 18 cannot be handled", ex.Message);
        }

        [Test]
        public void FactorialOfZero()
        {
            Calculator calc = new Calculator();
            double result = calc.Factorial(0);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void FactorialOfNegativeNumber()
        {
            Calculator calc = new Calculator();
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => calc.Factorial(-1));

            Assert.AreEqual("Factorial of minus numbers cannot be handled", ex.Message);
        }
    }
}