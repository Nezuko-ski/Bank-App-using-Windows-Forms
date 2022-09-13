using Microsoft.VisualStudio.CodeCoverage;
using BankAppCore.Models;
using BankAppCore.Services;
using Moq;
using BankAppCore.Interfaces;
using System;
using Xunit;
using Autofac.Extras.Moq;

namespace BankAppTest
{

    public class AccountOperationsTest
    {
        public Mock<ITransactions> mock = new Mock<ITransactions>();
        public Mock<IAccount> acc = new Mock<IAccount>();

        [Theory]
        [InlineData(5000, true)]
        [InlineData(-3000, false)]
        public void DepositTest1(double amt, bool expected)
        {
            var actual = amt > 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DepositTest2()
        {
            Transactions actual = new Transactions
            {
                AccountNumber = "7110336021",
                Amount = "40000"
            };
            mock.Setup(v => v.AddTransaction(actual));
            Assert.True(actual != null);
        }
    }
}
