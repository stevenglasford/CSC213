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

        [TestMethod]
        public void TestAccountDebit()
        {
            Account a = new Account(1.0m);
            a.Debit(1.0m);
            Assert.AreEqual(a.Balance, 0.0m);
        }

        [TestMethod]
        public void TestSavingsCalculateInterest()
        {
            SavingsAccount a = new SavingsAccount(10.0m,1.0m);
            Assert.AreEqual(0.1m, a.CalculateInterest());
        }

        [TestMethod]
        public void TestSavingsRate()
        {
            SavingsAccount a = new SavingsAccount(10.0m, 1.0m);
            Assert.AreEqual(10.0m, a.Balance);
        }

        [TestMethod]
        public void TestChequeingFee()
        {
            ChequeingAccount a = new ChequeingAccount(10.0m, 1.0m);
            a.Credit(2.0m);
            Assert.AreEqual(11.0m, a.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNegSav()
        {
            SavingsAccount a = new SavingsAccount(-10.0m, 1.0m);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWrongChequeingDebit()
        {
            ChequeingAccount a = new ChequeingAccount(10.0m, 1.0m);
            a.Debit(-2.0m);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWrongChequeingCredit()
        {
            ChequeingAccount a = new ChequeingAccount(10.0m, 1.0m);
            a.Credit(-2.0m);
        }

        [TestMethod]
        public void TestSavings()
        {
            ChequeingAccount a = new ChequeingAccount(10.0m, 1.0m);
            a.Credit(2.0m);
            Assert.AreEqual(11.0m, a.Balance);
        }

        [TestMethod]
        public void TestChequeing()
        {
            ChequeingAccount a = new ChequeingAccount(10.0m, 1.0m);
            Assert.AreEqual(10.0m, a.Balance);
            Assert.AreEqual(1.0m, a.Fee);
        }

    }
}
