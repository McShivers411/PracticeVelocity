using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PV_Event
{
    [TestClass]
    public class TestEvent
    {
        [TestMethod]
        public void TestEventType_Register()
        {
            Event TestEvent = new Event(1, "TestEvent", "Register");
            string TestOutput = "";
            string ExpectedOutput = "";
            int low = 3;
            int high = 5;

            for (int i = 1; i <= 100; i++) {
                if (i % low == 0 && i % high == 0) { ExpectedOutput += "Register Patient\r\n"; }
                else if (i % high == 0) { ExpectedOutput += "Patient\r\n"; }
                else if (i % low == 0) { ExpectedOutput += "Register\r\n"; }
                else ExpectedOutput += i.ToString() + "\r\n";
            }
            
            TestOutput = TestEvent.Process();

            Assert.IsTrue(string.Equals(TestOutput, ExpectedOutput));
        }

        [TestMethod]
        public void TestEventType_Diagnose()
        {
            Event TestEvent = new Event(1, "TestEvent", "Diagnose");
            string TestOutput = "";
            string ExpectedOutput = "";
            int low = 2;
            int high = 7;

            for (int i = 1; i <= 100; i++) {
                if (i % low == 0 && i % high == 0) { ExpectedOutput += "Diagnose Patient\r\n"; }
                else if (i % high == 0) { ExpectedOutput += "Patient\r\n"; }
                else if (i % low == 0) { ExpectedOutput += "Diagnose\r\n"; }
                else ExpectedOutput += i.ToString() + "\r\n";
            }

            TestOutput = TestEvent.Process();
            Assert.IsTrue(string.Equals(TestOutput, ExpectedOutput));
        }
    }
}
