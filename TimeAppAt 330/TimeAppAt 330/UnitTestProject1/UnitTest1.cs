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
            Time2 myTime = new Time2(2);
            //NUnit
            Assert.AreEqual(2, myTime.Hour);
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
            Time2 myTime = new Time2(11,12,30);
            //NUnit
            Assert.AreEqual(11, myTime.Hour);
            Assert.AreEqual(12, myTime.Minute);
            Assert.AreEqual(30, myTime.Second);

        }
        [TestMethod]
        public void TestMethodObj5()
        {
            Time2 myTime = new Time2();
            Time2 myTime55 = new Time2(myTime);

            //NUnit
            Assert.AreEqual(0, myTime55.Hour);
            Assert.AreEqual(0, myTime55.Minute);
            Assert.AreEqual(0, myTime55.Second);

        }

        //ToUniversalString
        [TestMethod]
        public void TestMethodToUniversalString()
        {
            Time2 myTime = new Time2(11,4,5);

            string expResult = "11:04:05";
            //NUnit
            Assert.AreEqual(expResult,
                myTime.ToUniversalString());

        }
        [TestMethod]
        public void TestMethodToStringAM()
        {
            Time2 myTime = new Time2(11, 4, 5);

            string expResult = "11:04:05 AM";
            //NUnit
            Assert.AreEqual(expResult,myTime.ToString());

        }

        [TestMethod]
        public void TestMethodToStringPM()
        {
            Time2 myTime = new Time2(14, 4, 5);

            string expResult = "2:04:05 PM";
            //NUnit
            Assert.AreEqual(expResult, myTime.ToString());

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodHour1()
        {
            Time2 myTime = new Time2(3,5,6);
            myTime.Hour = -1;
        }

        [TestMethod]

        [ExpectedException(typeof(Exception))]
        public void TestMethodHour2()
        {
            Time2 myTime = new Time2(3, 5, 6);
            myTime.Hour = 24;
        }
        [TestMethod]

        [ExpectedException(typeof(Exception))]
        public void TestMethodMin1()
        {
            Time2 myTime = new Time2(3, 5, 6);
            myTime.Minute = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodMin2()
        {
            Time2 myTime = new Time2(3, 5, 6);
            myTime.Minute = 61;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodSec1()
        {
            Time2 myTime = new Time2(3, 5, 6);
            myTime.Second = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodSec2()
        {
            Time2 myTime = new Time2(3, 5, 6);
            myTime.Second = 61;
        }
    }
}
