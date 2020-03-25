using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvaiablePlacementsForShipReturns2PlacementsForShipOfLengthInHorizontalGrid1x4()
        {
            Grid g = new Grid(1, 4);
            var result = g.GetAvaiablePlacements(3);
            Assert.AreEqual(2, result.Count());

            Assert.AreEqual(3, result.First().Count());
            Assert.AreEqual(3, result.Last().Count());
        }

        [TestMethod]
        public void GetAvaiablePlacementsForShipReturns3PlacementsForShipOfLengthInVerticalGrid5x1()
        {
            Grid g = new Grid(5, 1);
            var result = g.GetAvaiablePlacements(3);
            Assert.AreEqual(3, result.Count());

            foreach(var sequence in result)
                Assert.AreEqual(3, sequence.Count());
        }

        [TestMethod]
        public void GetAvaiablePlacementsForShipReturns3PlacementsForShipOfLength2InHorizontalGrid1x6AfterSquareIsEliminated()
        {
            Grid g = new Grid(1, 6);
            g.EliminateSquares(new List<Square> { new Square(1, 3) });
            var result = g.GetAvaiablePlacements(2);
            Assert.AreEqual(3, result.Count());

            Assert.AreEqual(3, result.First().Count());
            Assert.AreEqual(3, result.Last().Count());
        }

        [TestMethod]
        public void GetAvaiablePlacementsForShipReturns2PlacementsForShipOfLength2InVerticalGrid1x5AfterSquareIsEliminated()
        {
            Grid g = new Grid(5, 1);
            g.EliminateSquares(new List<Square> { new Square(1, 0) });
            var result = g.GetAvaiablePlacements(2);
            Assert.AreEqual(2, result.Count());

            foreach (var sequence in result)
                Assert.AreEqual(2, sequence.Count());
        }
    }
}
