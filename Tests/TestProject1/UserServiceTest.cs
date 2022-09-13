using Autofac.Extras.Moq;
using BankAppCore.Interfaces;
using BankAppCore.Models;
using BankAppCore.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BankAppTest
{
    public class UserServiceTest
    {
        [Fact]
        public void AddUserTest()
        {
            using (var moq = AutoMock.GetLoose())
            {
                Users user = new();
                moq.Mock<IReadWriteToJson>()
                    .Setup(v => v.WriteJson<Users>(user, "Users.json"))
                    .Returns(GetSampleUser());

                var test = moq.Create<UserService>();
                var expected = GetSampleUser();
                var actual = test.AddUser(user);
                Assert.Equal(expected.ToString().Length, actual.ToString().Length);
            };
        }

        [Fact]
        public void GetAllUserTest()
        {
            using (var moq = AutoMock.GetLoose())
            {
                Users user = new();
                moq.Mock<IReadWriteToJson>()
                    .Setup(v => v.ReadJson<Users>("Users.json"))
                    .Returns(GetSampleUsers());

                var test = moq.Create<UserService>();
                var expected = GetSampleUsers();
                var actual = test.GetAllUsers();
                Assert.Equal(expected.ToString().Length, actual.ToString().Length);
            };
        }

        [Fact]
        public void GetUserByIdTest()
        {
            using (var moq = AutoMock.GetLoose())
            {
                Users user = new();
                moq.Mock<IReadWriteToJson>()
                    .Setup(v => v.ReadJson<Users>("Users.json"))
                    .Returns(GetSampleUserById());

                var test = moq.Create<UserService>();
                var expected = GetSampleUserById();
                var actual = test.GetUserById("24c43695-0fba-4c1e-8337-18dc4d0e5020");
                Assert.True(expected != null);
                Assert.True(actual.ToString().Length > 0);
            }
        }

        private static Task<List<Users>> GetSampleUserById()
        {
            List<Users> users = new()
            {
                new Users()
                {
                    Id = "24c43695-0fba-4c1e-8337-18dc4d0e5020"
                },
                new Users()
                {
                    Id = "ffd01329-e50a-45c3-bdc6-0dd92e4740ba"
                }
            };
            return Task.FromResult(users);
        }

        private static Task<bool> GetSampleUser()
        {
            List<Users> users = new()
            {
                new Users
                {
                    FullName = "Nezuko Kamado",
                    EmailAddress = "nezukomylove@slayer.com"
                },
                new Users
                {
                    FullName = "Jones Touka",
                    EmailAddress = "touka@touka.com"
                },
                new Users
                {
                    FullName = "Jones Jones",
                    EmailAddress = "jones@jones.com"
                }
            };
            if (users.Count > 0)
                return Task.FromResult(true);
            return Task.FromResult(false);
        }

        private static Task<List<Users>> GetSampleUsers()
        {
            List<Users> users = new()
            {
                new Users
                {
                    FullName = "Nezuko Kamado",
                    EmailAddress = "nezukomylove@slayer.com"
                },
                new Users
                {
                    FullName = "Jones Touka",
                    EmailAddress = "touka@touka.com"
                },
                new Users
                {
                    FullName = "Jones Jones",
                    EmailAddress = "jones@jones.com"
                }
            };
            return Task.FromResult(users);
        }
    }
}
