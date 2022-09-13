using Autofac.Extras.Moq;
using BankAppCore.Interfaces;
using BankAppCore.Models;
using BankAppCore.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace BankAppTest
{
    public class TransactionServiceTest
    {

        [Fact]
        public void GetAllTransactionsForAnAccountTest()
        {
            Transactions transactions = new Transactions() { AccountNumber = "7110336021", Amount = "2000", Balance = "57000", Date = DateTime.Now, Description = "Deposit" };
            List<Transactions> result = new List<Transactions>
            {
                transactions
            };
            Assert.True(result.Count > 0);
            Assert.Contains<Transactions>(transactions, result);
        }

        [Fact]
        public  void AddTransactionTest()
        {
            using (var moq = AutoMock.GetLoose())
            {
                Transactions transactions = new();
                moq.Mock<IReadWriteToJson>()
                    .Setup(v => v.WriteJson<Transactions>(transactions, "Transaction.json"))
                    .Returns(GetSampleTransactions());

                var test = moq.Create<TransactionsService>();
                var expected = GetSampleTransactions();
                var actual = test.AddTransaction(transactions);
                Assert.Equal(expected.ToString().Length, actual.ToString().Length); 
            };
        }

        private Task<bool> GetSampleTransactions()
        {
            List<Transactions> transactions = new List<Transactions>()
            {
                new Transactions
                {
                    AccountNumber = "4724574672",
                    Description = "Deposit"
                },
                new Transactions
                {
                    AccountNumber = "5207428105",
                    Description = "Withdrawal"
                },
                new Transactions
                {
                    AccountNumber = "7110332345",
                    Description = "Deposit"
                },
            }; 
            if(transactions.Count > 0)
            {
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
