using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructures_Tests
{
    [TestClass]
    public class LinkedListUnitTest
    {
        private LinkedList<int> LL;

        [TestInitialize]
        public void Initialize()
        {
            LL = new LinkedList<int>();
        }

        [TestMethod]
        public void TestCount()
        {
            var expected = 0;
            var actual = LL.Count();

            Assert.AreEqual(expected, actual);
        }
    }
}
