using NUnit.Framework;
using Calc;

namespace Calclulator
{
    public class Tests
    {
        private Calculator calclulator;

        [SetUp]
        public void Setup()
        {
            calclulator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
           int result = calclulator.Sum(2, 3);
            Assert.That(result, Is.EqualTo(5));
            //Assert.Pass();
        }
    }
}