using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.BattleShip.Model.UnitTests
{
    [TestClass]
    public class TestLimitedQueue
    {
        [TestMethod]
        public void AddingItemsBehindLimitRemovesFirstIn()
        {
            LimitedQueue<int> g = new LimitedQueue<int>(3);
            Assert.AreEqual(0, g.Count);
            g.Enqueue(1);
            Assert.AreEqual(1, g.Count);
            g.Enqueue(2);
            Assert.AreEqual(2, g.Count);
            g.Enqueue(3);
            Assert.AreEqual(3, g.Count);
            g.Enqueue(4);
            Assert.AreEqual(3, g.Count);
            Assert.IsFalse(g.Contains(1));
        }
    }
}
