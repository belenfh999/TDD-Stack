using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack.Library;
using System;

namespace Stack.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CannPopOffEmptyStack()
        {
            var stack = new BasicStack(10);
            Assert.AreEqual(null,stack.Pop());
        }

        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new BasicStack(10);
            stack.Push(1);
            Assert.AreEqual(1,stack.Pop());
        }

        [TestMethod]
        public void CanPop2Items()
        {
            var stack = new BasicStack(10);
            stack.Push(1);
            stack.Push("fizzbuzz");
            Assert.AreEqual("fizzbuzz",stack.Pop());
            Assert.AreEqual(1,stack.Pop());
        }

        [TestMethod]
        public void CanPopMultipleItems()
        {
            var stack = new BasicStack(10);
            stack.Push(1);
            stack.Push("fizzbuzz");
            stack.Push("fizz");
            stack.Push("buzz");
            Assert.AreEqual("buzz",stack.Pop());
            Assert.AreEqual("fizz",stack.Pop());
            Assert.AreEqual("fizzbuzz",stack.Pop());
            Assert.AreEqual(1,stack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CannotPushNullItem()
        {
            var stack = new BasicStack(10);
            stack.Push(null);
        }

        [TestMethod]
        public void CannotPushNullItem2()
        {
            var stack = new BasicStack(10);

            Assert.ThrowsException<ArgumentNullException>(() => {
                stack.Push(null);
            });
        }
    }
}
