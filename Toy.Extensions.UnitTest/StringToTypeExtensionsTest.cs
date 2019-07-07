using Microsoft.VisualStudio.TestTools.UnitTesting;
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

    }
}
