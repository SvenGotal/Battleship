using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestShipWright
    {
        public void CreateFleetCreateShips()
        {
            ShipWright sw = new ShipWright(10, 10);
            var fleet = sw.CreateFleet(new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 });
            Assert.AreEqual(10, fleet.Ships.Count());
        }
    }
}
