// Importing NUnit.Framework and our application
using NUnit.Framework;
using Day9_MathLibrary_Testing_using_NUnit;


namespace MathLibrary.tests
{
    public class calculatorTests
    {
        private Calculator calculator;
        [SetUp]  // attribute to indicate that this method will run before each test
        public void Setup()
        {
            calculator = new Calculator(); // allocating memory using new keyword
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            //Assert.Pass(); // This line is a placeholder that indicates the test has passed without any assertions.
            int result = calculator.Add(2, 3);
            //Assert.AreEqual(5, result); // Asserting that the result of Add(2, 3) is equal to 5
            Assert.That(result, Is.EqualTo(5)); // Using Assert.That for a more readable assertion

        }
        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Assert.Pass();
            int result = calculator.Subtract(5, 3);
            //Assert.AreEqual(2, result); // Asserting that the result of Subtract(5, 3) is equal to 2
            Assert.That(result, Is.EqualTo(2)); // Using Assert.That for a more readable assertion
        }
    }
}