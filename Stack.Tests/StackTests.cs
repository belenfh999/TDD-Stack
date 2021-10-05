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
    }
}
