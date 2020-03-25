﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.BattleShip.Model
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementsForShipReturns2PlacementsForShipOfLenght3InHorizontalGrid1x4()
        {
            Grid g = new Grid(1, 4);
            var result = g.GetAvailablePlacements(3);
            Assert.AreEqual(2, result.Count());

            Assert.AreEqual(3, result.First().Count());
            Assert.AreEqual(3, result.Last().Count());
        }

        [TestMethod]
        public void GetAvailablePlacementsForShipReturns3PlacementsForShipOfLenght3InVerticalGrid5x1()
        {
            Grid g = new Grid(5, 1);
            var result = g.GetAvailablePlacements(3);
            Assert.AreEqual(3, result.Count());

            foreach (var sequence in result)
            {
                Assert.AreEqual(3, sequence.Count());
            }
        }
    }
}
