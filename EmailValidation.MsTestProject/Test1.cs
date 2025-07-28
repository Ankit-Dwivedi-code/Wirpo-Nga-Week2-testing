using System.ComponentModel.DataAnnotations;

namespace EmailValidation.MsTestProject
{
    [TestClass]
    public sealed class Test1
    {
        private EmailValidator validator;

        [TestInitialize]
        public void TestInitialize() {

            [TestMethod]
            public void TIsEmailValid_ShouldReturnFalseForInvalidEmail()
            {
                string input = "Invalid_email.com";
                bool result = Validator.IsEmailValid(input);
            }

            [TestMethod]
            public void IsEmailValid_ShouldReturnTrueForValidEmail()
            {
                string input = "Valid@example.com";
                bool result = validator.IsEmailValid(input);
                Assert.IsTrue(result);//we are checking for invalid Email value
            }
        }
    }
}
