using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementsForShipReturns2PlacementsForShipOfLength3InHorizontalGrid1X4()
        {
            Grid g = new Grid(1, 4);
            var result = g.GetAvailablePlacements(3);
            Assert.AreEqual(2, result.Count());

            Assert.AreEqual(3, result.First().Count());
            Assert.AreEqual(3, result.Last().Count());
        }
        [TestMethod]
        public void GetAvailablePlacementsForShipReturns3PlacementsForShipOfLength3InVerticalGrid5X1()
        {
            Grid g = new Grid(5, 1);
            var result = g.GetAvailablePlacements(3);
            Assert.AreEqual(3, result.Count());


            foreach(var sequence in result)
            Assert.AreEqual(3, sequence.Count());
        }


        [TestMethod]
        public void GetAvailablePlacementsForShipReturns3PlacementsForShipOfLength2InHorizontalGrid1X6AfterSquareIsEleminated()
        {
            Grid g = new Grid(1, 6);
            g.EleminateSquares(new List<Square> { new Square(0, 2) });
            var result = g.GetAvailablePlacements(2);
            Assert.AreEqual(3, result.Count());
        }
        [TestMethod]

    public void GetAvailablePlacementsForShipReturns2PlacementsForShipOfLength2InVerticalGrid5X1AfterSquareIsEliminated()
        {
            Grid g = new Grid(5, 1);
            g.EleminateSquares(new List<Square> { new Square(1, 0) });
            var result = g.GetAvailablePlacements(2);
            Assert.AreEqual(3, result.Count());

            foreach (var sequence in result)
                Assert.AreEqual(2, sequence.Count());

        }
    }
}

