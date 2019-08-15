using System;
using SampleExtensions.Demo1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethod.Tests.Demo1
{
    [TestClass]
    public class LegacyExtensionsTest
    {
        [TestMethod] 
        public void ToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLgacyFormat());
        }

        [TestMethod]
        public void ToLegacyFormat_C21()
        {
            var dateTime = new DateTime(2013, 10, 31);
            Assert.AreEqual("1131031", dateTime.ToLgacyFormat());
        }


        [TestMethod]
        public void ToLegacyName()
        {
            var name = "Ajileye Joseph";
            Assert.AreEqual("JOSEPH, AJILEYE", name.ToLgacyName());
        }
    }
}
