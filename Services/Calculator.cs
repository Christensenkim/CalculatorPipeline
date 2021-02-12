using System;
using System.Linq;

namespace Services
{
    public class Calculator : ICalculator
    {
        public double Add(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Subtract(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Multiply(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Divide(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Factorial(double number)
        {
            if (number >= 18)
            {
                throw new ArgumentOutOfRangeException("", "Factorial over 18 cannot be handled");
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("", "Factorial of minus numbers cannot be handled");
            }
            int i, fact = 1;

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            return fact;
        }
    }
}