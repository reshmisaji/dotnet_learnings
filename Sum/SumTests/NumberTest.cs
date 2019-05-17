using McKinsey.Calculator;
using NUnit.Framework;

namespace SumTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShouldCreateAnInstanceOfNumberType()
        {
            var number = new Number(3);
            Assert.IsInstanceOf(typeof(Number), number);
        }

        [Test]
        public void ShouldReturnTheValueOfANumber()
        {
            var num = new Number(3);
            Assert.AreEqual(3, num.GetValue());
        }
    }
}