//add our project as well as unit test packages
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Calculator_App;

namespace MathLibrary.MSTest
{
    [TestClass]
    public sealed class Test1
    {
        private Calculator calculates; // ref of Calculator class


        [TestInitialize]
        public void TestInitialize()
        {
            calculates = new Calculator();  //Instantiation || allocating memory for the Calculator object
        }

        [TestMethod]
        public void Add_ReturnsMultiply()
        {
            int result = calculates.Multiply(5, 5);
            //Assert.AreEqual(25, result, "Multiply method did not return the expected result.");
            Assert.AreEqual(25, result);
        }
        [TestMethod]
        public void Add_ReturnsDivide()
        {
            int result = calculates.Divide(5, 5);
            //Assert.AreEqual(5, result, "Divide method did not return the expected result.");
            Assert.AreEqual(1, result);
        }
    }

    public class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}