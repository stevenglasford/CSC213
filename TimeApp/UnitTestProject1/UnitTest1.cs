using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodObj1()
        {
            Time2 myTime = new Time2();
            //NUnit
            Assert.AreEqual(0, myTime.Hour);
            Assert.AreEqual(0, myTime.Minute);
            Assert.AreEqual(0, myTime.Second);
        }

        [TestMethod]
        public void TestMethodObj2()
        {
            Time2 myTime = new Time2(11);
            //NUnit
            Assert.AreEqual(11, myTime.Hour);
            Assert.AreEqual(0, myTime.Minute);
            Assert.AreEqual(0, myTime.Second);
        }

        [TestMethod]
        public void TestMethodObj3()
        {
            Time2 myTime = new Time2(11,30);
            //NUnit
            Assert.AreEqual(11, myTime.Hour);
            Assert.AreEqual(30, myTime.Minute);
            Assert.AreEqual(0, myTime.Second);
        }

        [TestMethod]
        public void TestMethodObj4()
        {
            Time2 myTime = new Time2(11,30,20);
            //NUnit
            Assert.AreEqual(11, myTime.Hour);
            Assert.AreEqual(30, myTime.Minute);
            Assert.AreEqual(20, myTime.Second);
        }

        [TestMethod]
        public void TestMethodObj5()
        {
            Time2 myTime = new Time2(11, 30, 20);
            Time2 myTime55 = new Time2(myTime);
            //NUnit
            Assert.AreEqual(11, myTime55.Hour);
            Assert.AreEqual(30, myTime55.Minute);
            Assert.AreEqual(20, myTime55.Second);
        }

        //ToUniversalString
        [TestMethod]
        public void TestMethodToUniversalString()
        {
            Time2 myTime = new Time2(11, 30, 20);

            string expResult = "11:30:20";
            //NUnit
            Assert.AreEqual(expResult,myTime.ToUniversalString());
            
        }

        [TestMethod]
        public void TestMethodToStringAM()
        {
            Time2 myTime = new Time2(11, 30, 20);

            string expResult = "11:30:20 AM";
            //NUnit
            Assert.AreEqual(expResult, myTime.ToString());

        }
    }

}
