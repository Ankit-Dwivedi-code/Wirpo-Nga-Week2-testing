using Xunit;// adding refernce of the project 
using Day9_EmailValidation_usingMSTestandXUnitFramework;

namespace EmailValidation.xUnit
{
    public class UnitTest1
    {
        private readonly EmailValidator validator = new EmailValidator();
        [Fact]
        public void IsEmailValid_ShouldReturnFalseForInvalidEmail()
        {
            string input = "no-at-symbol.com";
            bool result = validator.IsEmailValid(input);
            Assert.False(result);//for wrong Email IDs
        }

        [Fact]
        public void IsEmailValid_ShouldReturnTrueForValidEmail()
        {
            string input = "test.user@example.com";
            bool result = validator.IsEmailValid(input);
            Assert.True(result);//
        }
    }
}