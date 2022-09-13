using BankAppCore.Models;
using Microsoft.VisualStudio.CodeCoverage;
using Xunit;

namespace BankAppTest
{
    public class RegisterTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            Users user = new Users()
            {
                FullName = "Nezuko Kamado"
            };
            string expected = "Nezuko Kamado";
            string actual = user.FullName;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void EmailTestValid()
        {
            Users user = new Users()
            {
                EmailAddress = "nezukomylove@slayer.com"
            };
            string expected = user.EmailAddress;

            Assert.NotNull(expected);
        }
        [Fact]
        public void PasswordTestValid()
        {
            Users user = new Users()
            {
                Password = "Nezuko@4"
            };
            string expected = "Nezuko@4";
            string actual = user.Password;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AgeTestValid()
        {
            Users user = new Users()
            {
                Age = "12"
            };
            string expected = "12";
            string actual = user.Age;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsActiveTestValid()
        {
            Users user = new Users()
            {
                IsActive = true
            };
            bool expected = true;
            bool actual = user.IsActive;

            Assert.Equal(expected, actual);
        }
    }
}