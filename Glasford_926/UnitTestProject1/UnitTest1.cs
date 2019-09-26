using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Glasford_926;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNegativeBalance()
        {
            Account a = new Account(-1.0m);
        }

        [TestMethod]
        public void TestAccountBalance()
        {
            Account a = new Account(1.0m);
            Assert.AreEqual(a.Balance, 1.0m);
        }

        [TestMethod]
        public void TestAccountCredit()
        {
            Account a = new Account(1.0m);
            a.Credit(1.0m);
            Assert.AreEqual(a.Balance, 2.0m);
        }
    }
}
