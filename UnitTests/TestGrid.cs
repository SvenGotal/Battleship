using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void getAvaliablePlacementsFroShipReturns2PlacementsForShipOfLenght3InHorizontalGrid1x4()
        {
            grid g = new grid(1, 4);
            var result = g.GetAvaliablePlacements(3);
            Assert.AreEqual(2, result.Count());

            Assert.AreEqual(3, result.First().Count());
            Assert.AreEqual(3, result.Last().Count());
        }
        [TestMethod]
        public void getAvaliablePlacementsFroShipReturns3PlacementsForShipOfLenght3InVerticalGrid5x1()
        {
            grid g = new grid(5, 1);
            var result = g.GetAvaliablePlacements(3);
            Assert.AreEqual(3, result.Count());

            foreach (var seq in result)
            {
                Assert.AreEqual(3, seq.Count());
            }
        }
    }
}
