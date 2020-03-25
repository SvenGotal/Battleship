using System;
using System.Linq;
using System.Collections.Generic;
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
        [TestMethod]
        public void getAvaliablePlacementsFroShipReturns3PlacementsForShipOfLenght2InHorizontalGrid1x6AfterSquareIsElimianted()
        {
            grid g = new grid(1, 6);
            g.eliminateSquares(new List<square> { new square(0,2)});
            var result = g.GetAvaliablePlacements(2);
            Assert.AreEqual(3, result.Count());

        }
        [TestMethod]
        public void getAvaliablePlacementsFroShipReturns2PlacementsForShipOfLenght2InVerticalGrid5x1AfterSquareIsElimianted()
        {
            grid g = new grid(5, 1);
            g.eliminateSquares(new List<square> { new square(1, 0) });
            var result = g.GetAvaliablePlacements(2);
            Assert.AreEqual(2, result.Count());

            foreach (var seq in result)
            {
                Assert.AreEqual(2, seq.Count());
            }
        }
    }
}
