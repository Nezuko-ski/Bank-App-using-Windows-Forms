using BankAppCore.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankAppTest
{
    public class UtilitiesTest
    {
        [Theory]
        [InlineData("Nezuko@4", "86c4571bc7459952c50fac063ca35c5eebec89178b29b246fb10d0e99db64dc8")]
        [InlineData("Jones@jones4", "e1a325f3603f55f12c7b2e6e6a8f3ec605c92347763ba7d2f3d270e2b0ff5922")]
        public void ComputeSha256HashTest(string rawData, string expected)
        {
            Utilities utils = new(); 
            string actual = utils.ComputeSha256Hash(rawData);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(10, "4724574672")]
        [InlineData(10, "5207428105")]
        public void GenerateRandomTest(int len, string expected)
        {
            Utilities utils = new();
            string actual = utils.GenerateRandom(10);
            Assert.Equal(expected.Length, actual.Length);
        }
    }

    
}
