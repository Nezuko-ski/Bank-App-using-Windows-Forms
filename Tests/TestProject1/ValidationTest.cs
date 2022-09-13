using Xunit;
using BankAppCore.Helper;

namespace BankAppTest
{
    public class ValidationTest
    {
        [Theory]
        [InlineData("jones", false)]
        [InlineData("Jones", true)]
        [InlineData("nezuko", false)]
        [InlineData("kamado", false)]
        public void ValidateNameTest(string name, bool expected)
        {
            Validators validators = new Validators();
            bool actual = validators.ValidateName(name);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("jones@jones", false)]
        [InlineData("jones@jones.com", true)]
        [InlineData("nezukomylove@slayer", false)]
        [InlineData("nezukomylove@slayer.com", true)]
        public void ValidateEmailTest(string email, bool expected)
        {
            Validators validators = new Validators();
            bool actual = validators.ValidateEmail(email);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("jones4", false)]
        [InlineData("Jones@jones4", true)]
        [InlineData("nezuko@kamado4", false)]
        [InlineData("Nezuko@slayer4", true)]
        public void ValidatePasswordTest(string password, bool expected)
        {
            Validators validators = new Validators();
            bool actual = validators.ValidatePassword(password);
            Assert.Equal(expected, actual);
        }
    }
}
