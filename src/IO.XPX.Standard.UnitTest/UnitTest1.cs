using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IO.XPX.Standard.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var _download = new Api.Download();
            Assert.AreEqual(0, _download.Test());
        }
    }
}
