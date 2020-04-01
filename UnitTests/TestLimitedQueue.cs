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

            LimitedQueue<int> qu = new LimitedQueue<int>(3);
            Assert.AreEqual(0, qu.Count);
            qu.Enqueue(1);
            Assert.AreEqual(1, qu.Count);
            qu.Enqueue(2);
            Assert.AreEqual(2, qu.Count);
            qu.Enqueue(3);
            Assert.AreEqual(3, qu.Count);
            qu.Enqueue(4);
            Assert.AreEqual(3, qu.Count);
            Assert.IsFalse(qu.Contains(1));

        }
    }
}
