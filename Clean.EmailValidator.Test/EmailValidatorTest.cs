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

        [Test, Description("ensure EmailValidator returns false if an empty email is provided.")]
        public void EmailValidator_EmptyEmail_ReturnsFalse()
        {
            Assert.That(EmailValidator.Validate(""), Is.EqualTo(false));
        }

        [Test, Description("ensure EmailValidator returns true if a valid email is provided.")]
        public void EmailValidator_ValidEmail_ReturnsTrue()
        {
            Assert.That(EmailValidator.Validate("valid_email@mail.com"), Is.EqualTo(true));
        }
    }
}
