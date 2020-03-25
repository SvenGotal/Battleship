using System;
using System.Linq;
using Generics.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementsForShipReturns2PlacementsForShipOfLength3InHorizontalGrid1x4()
        {
            Grid g = new Grid(1, 4);
            var result = g.GetAvailablePlacements(3);
            Assert.AreEqual(2, result.Count());

            Assert.AreEqual(3, result.First().Count());
            Assert.AreEqual(3, result.Last().Count());
        }

        [TestMethod]
        public void GetAvailablePlacementsForShipReturns2PlacementsForShipOfLength3InVerticalGrid5x4()
        {
            Grid g = new Grid(5, 4);
            var result = g.GetAvailablePlacements(3);
            Assert.AreEqual(3, result.Count());

            foreach(var sequence in result)
            Assert.AreEqual(3, sequence.Count());
        }

        /////
        ///
        [TestMethod]
        public void GetAvailablePlacementsForShipReturns2PlacementsForShipOfLength2InHorizontalGrid1x6AfterSquareIsEliminated()
        {
            Grid g = new Grid(1, 6);
            g.EliminateSquares(new List<Square>{ new Sqaure(0,2) });
            var result = g.GetAvailablePlacements(3);
            Assert.AreEqual(2, result.Count());

            
        }

        [TestMethod]
        public void GetAvailablePlacementsForShipReturns2PlacementsForShipOfLength2InVerticalGrid5x1AfterSquareIsEliminated()
        {
            Grid g = new Grid(5, 1);
            g.EliminateSquares(new List<Square> { new Sqaure(1, 0) });
            var result = g.GetAvailablePlacements(2);
            Assert.AreEqual(2, result.Count());

            foreach (var sequence in result)
                Assert.AreEqual(2, sequence.Count());
        }
    }
}
