using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethod.Tests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void ProperStringTest()
        {
            var stringValue = "joE is not  ";
            Assert.AreEqual("Joe is not", stringValue.ToUpperString());
        }
    }
}
