using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.test
{
    [TestClass]
    public class StackUnitTests
    {
        [TestMethod]
        public void Test_StackPush()
        {
            var myStack = new Stack<int>();
            myStack.Push(5);
            Console.WriteLine(myStack.Size);
            Assert.IsTrue(myStack.Size == 1);
        }

        [TestMethod]
        public void Test_StackPop()
        {
            var collection = new int[5] { 0, 1, 2, 3, 4 };

            var myStack = new Stack<int>(collection);
            var length = 5;
            var expectedLength = 4;

            Assert.IsTrue(myStack.Size == length);
            myStack.Pop();
            Assert.IsTrue(myStack.Size == expectedLength);
        }

        [TestMethod]
        public void Test_PopEmptyStack()
        {
            var myStack = new Stack<int>();
            Assert.IsTrue(myStack.Size == 0);
        }

        [TestMethod]
        public void Test_PushFullStack()
        {
            var collection = new string[]{
                "David",
                "Is",
                "Awesome"
            };
            var myStack = new Stack<string>(collection);
            Assert.ThrowsException<Exception>(() => myStack.Push("Blow up!"));
        }



    }
}
