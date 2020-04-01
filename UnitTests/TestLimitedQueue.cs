using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestLimitedQueue
    {
        [TestMethod]
        public void AddingItemsBehindLimitRemovesFirstIn()
        {
            LimitedQueue < int >queue= new LimitedQueue<int>(3);
            Assert.AreEqual(0, queue.Count);
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.Count);
            queue.Enqueue(2);
            Assert.AreEqual(2, queue.Count);
            queue.Enqueue(3);
            Assert.AreEqual(3, queue.Count);
            queue.Enqueue(4);
            Assert.AreEqual(3, queue.Count);
            Assert.IsFalse(queue.Contains(1));
            Assert.IsTrue(queue.Contains(4));
        }
    }
}
