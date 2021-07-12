using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Toy.Extensions.Extensions;

namespace Toy.Extensions.UnitTest
{
    [TestClass]
    public class StringToTypeExtensionsTest
    {
        [TestMethod]
        public void ToIntSuccessTest()
        {
            var strInt = "100223";
            var intValue = strInt.ToInt();
            Assert.AreEqual(100223, intValue);
        }

        [TestMethod]
        public void ToIntFailTest()
        {
            var strInt = "12hjhj";
            var intValue = strInt.ToInt();
            Assert.AreEqual(null, intValue);
        }

        [TestMethod]
        public void ToIntFailByNullTest()
        {
            string strInt = null;
            var intValue = strInt.ToInt();
            Assert.AreEqual(null, intValue);
        }

        [TestMethod]
        public void ToGuidSuccessTest()
        {
            Guid guid = Guid.NewGuid();
            string strGuid = guid.ToString();
            var guidValue = strGuid.ToGuid();
            Assert.AreEqual(guid, guidValue);
        }

        [TestMethod]
        public void ToGuidFailByNullTest()
        {
            Guid guid = Guid.NewGuid();
            string strGuid = guid.ToString() + "__"; // make the guid incorrect
            var guidValue = strGuid.ToGuid();
            Assert.AreEqual(null, guidValue, "Exepcted null"); 
        }

    }
}
