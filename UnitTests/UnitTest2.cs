using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model
{
    [TestClass]
    public class TestFleet
    {
        [TestMethod]
        public void AddShipCrreatesNewShipInTheFleet()
        {
            Fleet fleet = new Fleet();
            Assert.IsTrue(ship.Squares.Contains(new Square(1, 4)));
            Assert.IsTrue(ship.Squares.Contains(new Square(1, 5)));
            Assert.IsTrue(ship.Squares.Contains(new Square(1, 6)));
        }
    }
}
