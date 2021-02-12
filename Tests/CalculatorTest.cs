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
            //Setup
            var calc = new Calculator();

            //Act
            var result = calc.Subtract();

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            //Setup
            var calc = new Calculator();
            double[] testData = { 10, 2 };

            //Act
            var result = calc.Subtract(testData);

            //Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            //Setup
            var calc = new Calculator();
            double[] testData = { -10, -2 };

            //Act
            var result = calc.Subtract(testData);

            //Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void DivideTwoNumbersWithZero()
        {
            var calc = new Calculator();
            double[] testData = { 10, 2, 0 };

            Assert.Throws<DivideByZeroException>(() => {
                var result = calc.Subtract(testData);
            });
        }

        [Test]
        public void DivideThreeNumbersWithZero()
        {
            var calc = new Calculator();
            double[] testData = { 10, 2, 5, 0 };

            Assert.Throws<DivideByZeroException>(() => {
                var result = calc.Subtract(testData);
            });
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