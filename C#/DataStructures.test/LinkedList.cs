using System;
using DataStructures.library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.test
{
    [TestClass]
    public class LinkedList
    {
        private LinkedList<int> list;

        [TestInitialize]
        public void Setup()
        {
            list = new LinkedList<int>();
        }

        [TestMethod]
        public void Test_PushHead()
        {
            list.PushHead(10);
            Assert.IsTrue(list.Length == 1);
        }

        [TestMethod]
        public void Test_PushTail()
        {
            list.PushTail(1);
            list.PushTail(5);
            Assert.IsTrue(list.Head.Value == 1);
            Assert.IsTrue(list.Length == 2);
        }
    }
}