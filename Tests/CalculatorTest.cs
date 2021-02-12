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
            Calculator cal = new Calculator();
            
            var ex = Assert.Throws<Exception>(() => cal.Add());

            Assert.Equals("input is nothing", ex.Message);
        }

        [Test]
        public void AddTwoPositiveNumbers()
        {
            Calculator cal = new Calculator();

            double[] list = { 1.5, 1.5 };

            var result = cal.Add(list);

            Assert.IsTrue(3 == result);

        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            Calculator cal = new Calculator();

            double[] list = { -1.5, -1.5 };

            var result = cal.Add(list);

            Assert.IsTrue(-3 == result);
        }

        [Test]
        public void AddThreePositiveNumbers()
        {
            Calculator cal = new Calculator();

            double[] list = { 1.5, 1.5, 2 };

            var result = cal.Add(list);

            Assert.IsTrue(5 == result);
        }

        [Test]
        public void AddThreeNegativeNumbers()
        {
            Calculator cal = new Calculator();

            double[] list = { -1.5, -1.5, -2 };

            var result = cal.Add(list);

            Assert.IsTrue(-5 == result);
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