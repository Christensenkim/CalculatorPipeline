using NUnit.Framework;
using Services;
using System.Collections;

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
            //Setup
            var calc = new Calculator();

            //Act
            var result = calc.Subtract();

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void SubtractTwoPositiveNumbers()
        {
            //Setup
            var calc = new Calculator();
            double[] testData = { 2.5, 3.5 };

            //Act
            var result = calc.Subtract(testData);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void SubtractTwoNegativeNumbers()
        {
            //Setup
            var calc = new Calculator();
            double[] testData = { -2.5, -3.5 };

            //Act
            var result = calc.Subtract(testData);

            //Assert
            Assert.AreEqual(-6, result);
        }

        [Test]
        public void SubtractThreePositiveNumbers()
        {
            //Setup
            var calc = new Calculator();
            double[] testData = { 10.5, 2.5, 5.0 };

            //Act
            var result = calc.Subtract(testData);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void SubtractThreeNegativeNumbers()
        {
            //Setup
            var calc = new Calculator();
            double[] testData = { -10.5, -2.5, -5.0 };

            //Act
            var result = calc.Subtract(testData);

            //Assert
            Assert.AreEqual(-18, result);
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