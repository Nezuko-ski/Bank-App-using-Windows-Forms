using BankAppCore.Models;
using Microsoft.VisualStudio.CodeCoverage;
using Xunit;

namespace BankAppTest
{
    public class AccountTest
    {
        [Fact]
        public void AccountNoTestValid()
        {
            Accounts acc = new Accounts()
            {
                AccountNumber = "5207428105",
            };
            string expected = "5207428105";
            string actual = acc.AccountNumber;

            Assert.Equal(expected, actual);
        }
    }
}
