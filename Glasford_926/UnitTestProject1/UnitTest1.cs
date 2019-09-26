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
            Account a = new Account(-1);
        }
    }
}
