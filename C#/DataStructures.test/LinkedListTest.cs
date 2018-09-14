using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.test
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void Test_Push()
        {
            var list = new LinkedList<int>();
            list.PushEnd(1);
            Assert.IsTrue(list.Length == 1);
            Assert.IsTrue(list.Last.Value == 1);
            list.PushFront(10);
            Assert.IsTrue(list.Front.Value == 10);
            Assert.IsTrue(list.Length == 2);
            list.PopFront();
            Assert.IsTrue(list.Front.Value == 1);
        }
    }
}