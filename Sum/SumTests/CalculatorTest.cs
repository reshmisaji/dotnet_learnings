using McKinsey.Calculator;
using NUnit.Framework;

namespace SumTests
{
    public class CalculatorTest
    {
        [Test]
        public void ShouldCreateAnInstanceOfACalculator()
        {
            var calculator = new Calculator();
            
            Assert.IsInstanceOf(typeof(Calculator),calculator);
        }

        [Test]
        public void ShouldAddTwoNumbersAndReturnResult()
        {
            var firstNumber = new Number(3);
            var secondNumber = new Number(2);
            
            var actualSum = Calculator.Add(firstNumber, secondNumber);
            const int expectedSum = 5;
            
            Assert.IsInstanceOf(typeof(Result),actualSum);
            Assert.AreEqual(expectedSum,actualSum.GetValue());
        }

        [Test]
        public void ShouldReturnTheDifferenceOfTwoNumbers()
        {
            var firstNumber = new Number(3);
            var secondNumber = new Number(2);

            var actualDifference = Calculator.Subtract(firstNumber, secondNumber);
            const int expectedDifference = 1;
            
            Assert.IsInstanceOf(typeof(Result),actualDifference);
            Assert.AreEqual(expectedDifference,actualDifference.GetValue());
        }

        [Test]
        public void ShouldReturnTheProductOfTwoNumbers()
        {
            var firstNumber = new Number(3);
            var secondNumber = new Number(2);

            var actualProduct = Calculator.Multiply(firstNumber, secondNumber);
            const int expectedProduct = 6;
            
            Assert.IsInstanceOf(typeof(Result),actualProduct);
            Assert.AreEqual(expectedProduct,actualProduct.GetValue());
        }

        [Test]
        public void ShouldReturnTheQuotientOfTwoNumbers()
        {
            var firstNumber = new Number(3);
            var secondNumber = new Number(2);

            var actualQuotient = Calculator.Divide(firstNumber, secondNumber);
            const int expectedQuotient = 1;
            
            Assert.IsInstanceOf(typeof(Result),actualQuotient);
            Assert.AreEqual(expectedQuotient,actualQuotient.GetValue());
        }
    }
}