using System;
using DataStructures.library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.test
{
    [TestClass]
    [TestCategory("DataStructure - Linked List")]
    public class DoublyLinkedListTest
    {

        private DoublyLinkedList<string> list;

        [TestInitialize]
        public void Setup()
        {
            list = new DoublyLinkedList<string>();
        }

        [TestMethod]
        public void Test_Push()
        {
            list.PushEnd("David");
            Assert.IsTrue(list.Length == 1);
            Assert.IsTrue(list.Front.Value == "David");
            Assert.IsTrue(list.Last.Value == "David");
            Assert.IsTrue(list.Last.Next == null);
            Assert.IsTrue(list.Front.Next == null);

            list.PushFront("Ly");
            Assert.IsFalse(list.Length == 1);
            Assert.IsTrue(list.Length == 2);
            Assert.IsTrue(list.Front.Value == "Ly");
            Assert.IsTrue(list.Last.Value == "David");
        }

        [TestMethod]
        public void Test_Pop()
        {
            list.PushEnd("David");
            list.PopEnd();
            Assert.IsTrue(list.Length == 0);
            list.PushEnd("Ly");
            list.PushFront("David");
            list.PopFront();
            Assert.IsTrue(list.Length == 1);
            Assert.IsTrue(list.Front.Value == "Ly");
        }

        [TestMethod]
        public void Test_InsertAfter()
        {
            list.PushEnd("David");
            list.PushEnd("Ly");
            list.PushEnd("Likes");
            list.PushEnd("Jurassic");
            list.PushEnd("World");

            list.InsertAfter("Ly", "And");
            list.InsertAfter("And", "Nhan");

            Assert.IsTrue(list.Length == 7);
        }

        [TestMethod]
        public void Test_Delete()
        {
            list.PushEnd("David");
            list.PushEnd("Ly");
            list.PushEnd("Likes");
            list.PushEnd("Jurassic");
            list.PushEnd("World");

            list.InsertAfter("Ly", "And");
            list.InsertAfter("And", "Nhan");

            list.DeleteNode("And");
            list.DeleteNode("Nhan");

            Assert.IsTrue(list.Length == 5);
        }
    }
}