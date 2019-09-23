using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvoiceApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodObj1()
        {
            Invoice MyInvoice = 
                new Invoice(111, "aaa", 4, 56);

            //unit test with NUnit
            Assert.AreEqual(111, MyInvoice.PartNumber);
            Assert.AreEqual("aaa", MyInvoice.PartDescription);
            Assert.AreEqual(4, MyInvoice.Quantity);
            Assert.AreEqual(56, MyInvoice.Price);
        }

        [TestMethod]
        public void TestMethodQty()
        {
            Invoice MyInvoice =
                new Invoice(111, "aaa", 4, 56);
            MyInvoice.Quantity = -1;
            int expVal = 4;
            //NUnit
            Assert.AreEqual(expVal, MyInvoice.Quantity);
        }

        [TestMethod]
        public void TestMethodPrice()
        {
            Invoice MyInvoice =
                new Invoice(111, "aaa", 4, 56);
            MyInvoice.Price = -1;
            int expVal = 56;
            //NUnit
            Assert.AreEqual(expVal, MyInvoice.Price);
        }

        //return string.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
        //       PartNumber, PartDescription, Quantity, Price);
        [TestMethod]
        public void TestMethodToString()
        {
            Invoice MyInvoice =
                new Invoice(111, "aaaaaaaaaa", 4, 356);
            //change the spaces to make it work
            string expVal = "111  " + "aaaaaaaaaa          " + "4    " + "$356.00";
            
            //NUnit
            Assert.AreEqual(expVal, MyInvoice);
        }
        //I forgot about that, or do you want to try that new taco place in the basement

    }
}
