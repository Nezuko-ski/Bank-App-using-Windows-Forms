using Moq;
using Xunit;
using BankAppCore.Services;
using Autofac.Extras.Moq;
using BankAppCore.Interfaces;
using BankAppCore.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BankAppTest
{
    public class AccountServiceTest
    {
        [Fact]
        public void GetAccountDetailsTest()
        {
            AccountService act = new AccountService();
            var acc = act.GetAllAccounts();
            var expected = act.GetAccountDetails("4724574672");
            
            Assert.True(expected.ToString().Length > 9);
        }

        [Fact]
        public void AddAccountTest()
        {
            using (var moq = AutoMock.GetLoose())
            {
                Accounts accounts = new Accounts();
                moq.Mock<IReadWriteToJson>()
                    .Setup(v => v.WriteJson<Accounts>(accounts, "Accounts.json"))
                    .Returns(GetSampleAccount());

                var test = moq.Create<AccountService>();
                var expected = GetSampleAccounts();
                var actual = test.AddAccount(accounts);
                Assert.Equal(expected.ToString().Length, actual.ToString().Length);
            }; 
        }

        [Fact]
        public async void UpdateAccountTest()
        {
            using (var moq = AutoMock.GetLoose())
            {
                Accounts acc = new()
                {
                    AccountNumber = "4724574672",
                    Balance = 2040000.0,
                    AccountType = "Current",
                    UserId = null
                };
                List<Accounts> account = new()
                {
                    new Accounts
                    {
                        AccountNumber = "4724574672",
                        Balance = 2040000.0,
                        AccountType = "Current",
                        UserId = null
                    },
                    new Accounts
                    {
                        AccountNumber = "5207428105",
                        Balance = 14000.0,
                        AccountType = "Savings",
                        UserId = null
                    }
                };
                moq.Mock<IReadWriteToJson>()
                    .Setup(v => v.UpdateJson<Accounts>(account, "Accounts.json"));
                    
                var test = moq.Create<AccountService>();
                await test.UpdateAccount(acc);

                moq.Mock<IReadWriteToJson>()
                   .Verify(v => v.UpdateJson<Accounts>(account, "Accounts.json"), Times.Exactly(0));
            }
        }

        private List<Accounts> GetSampleAccounts()
        {
            List<Accounts> acc = new()
            {
                new Accounts
                {
                    AccountNumber = "7110336021",
                    Balance = 40000
                },
                new Accounts
                {
                    AccountNumber = "5207428105",
                    Balance = 23000
                },
                new Accounts
                {
                    AccountNumber = "7110332345",
                    Balance = 12000
                },
            };
            return acc;
        }

        private Task<bool> GetSampleAccount()
        {
            List<Accounts> acc = new List<Accounts>()
            {
                new Accounts
                {
                    AccountNumber = "7110336021",
                    Balance = 40000
                },
                new Accounts
                {
                    AccountNumber = "5207428105",
                    Balance = 23000
                },
                new Accounts
                {
                    AccountNumber = "7110332345",
                    Balance = 12000
                },
            };
            if (acc.Count > 0)
            {
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }

}
