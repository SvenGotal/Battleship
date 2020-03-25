﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvaliablePlacementsForShipReturns2PlacementsForShipOfLenght3InHorizontalGrid1x4()
        {
            Grid g = new Grid(1, 4);
            var result = g.GetAvaliablePlacements(3);
            Assert.AreEqual(2, result.Count());

            Assert.AreEqual(3, result.First().Count());
            Assert.AreEqual(3, result.Last().Count());


        }

        [TestMethod]
        public void GetAvaliablePlacementsForShipReturns3PlacementsForShipOfLenght3InHorizontalGrid5x1()
        {
            Grid g = new Grid(5, 1);
            var result = g.GetAvaliablePlacements(3);
            Assert.AreEqual(3, result.Count());

            foreach(var sequence in result)
            Assert.AreEqual(3, sequence.Count());
        }
    }
}
