using McKinsey.Calculator;
using NUnit.Framework;

namespace SumTests
{
    public class ResultTest
    {
        [Test]
        public void ShouldCreateAnInstanceOfResult()
        {
            var result = new Result(new Number(3));
            
            Assert.IsInstanceOf(typeof(Result),result);
        }

        [Test]
        public void ShouldReturnTheValueOfResult()
        {
            var result = new Result(new Number(3));
            const int expectedResult = 3;
            var actualResult = result.GetValue();
            
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}