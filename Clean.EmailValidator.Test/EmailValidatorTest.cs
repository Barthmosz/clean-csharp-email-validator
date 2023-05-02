using NUnit.Framework;

namespace Clean.EmailValidator.Test
{
    [TestFixture]
    public class EmailValidatorTest
    {
        [Test, Description("ensure EmailValidator returns false if an invalid email is provided.")]
        public void EmailValidator_InvalidEmail_ReturnsFalse()
        {
            Assert.That(EmailValidator.Validate("@mail.com"), Is.EqualTo(false));
        }
    }
}
