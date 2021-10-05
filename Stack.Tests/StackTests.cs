using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack.Library;

namespace Stack.Tests
{
    [TestClass]
    public class StackTests
    {
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
    }
}
