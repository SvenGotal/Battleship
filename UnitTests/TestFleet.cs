using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Vsite.Oom.Battleship.Model
{
    [TestClass]
    public class TestFleet //NEDOVRSENO
    {
        [TestMethod]
        public void AddShipCreatesNewShipInTheFleet()
        {
            fleet Fleet = new fleet();
            Fleet.addShip(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6)});
            Assert.AreEqual(1, Fleet.Ships.Count());
            Assert.IsTrue(Fleet.Ships.First().squares.Contains(new Square(1, 4)));
            Assert.IsTrue(Fleet.Ships.First().squares.Contains(new Square(1, 5)));
            Assert.IsTrue(Fleet.Ships.First().squares.Contains(new Square(1, 6)));
            Fleet.addShip(new List<Square> { new Square(4, 5), new Square(5, 5), new Square(6, 5) });
            Assert.AreEqual(2, Fleet.Ships.Count());
        }
    }
}
