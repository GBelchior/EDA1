using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EDA1.Lib.DataStructures;

namespace EDA1.UnitTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestElementCount()
        {
            MyStack<int> stack = new MyStack<int>(3);
            Assert.AreEqual(true, stack.IsEmpty());
            Assert.AreEqual(false, stack.IsFull());

            stack.Push(1);
            Assert.AreEqual(false, stack.IsEmpty());
            Assert.AreEqual(false, stack.IsFull());

            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(false, stack.IsEmpty());
            Assert.AreEqual(true, stack.IsFull());
        }

        [TestMethod]
        public void TestPushPop()
        {
            MyStack<int> stack = new MyStack<int>(4);
            stack.Push(1);

            Assert.AreEqual(1, stack.Pop());

            stack.Push(2);
            Assert.AreEqual(2, stack.Top());

            stack.Push(3);
            Assert.AreEqual(3, stack.Top());

            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "The stack has no items")]
        public void TestPopEmptyStack()
        {
            MyStack<int> stack = new MyStack<int>(3);
            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException), "The stack is full")]
        public void TestPushFullStack()
        {
            MyStack<string> stack = new MyStack<string>(1);
            stack.Push("test");
            stack.Push("test2");
        }
    }
}
