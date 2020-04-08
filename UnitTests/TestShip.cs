using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Vsite.Oom.Battleship.Model
{
    [TestClass]
    public class TestShip
    {
        [TestMethod]
        public void ConstructorCreateShipFromSquaresProvided()
        {
            ship Ship = new ship(new List<Square> { new Square(1,4), new Square(1, 5), new Square(1, 6) });
            Assert.IsTrue(Ship.squares.Contains(new Square(1, 4)));
            Assert.IsTrue(Ship.squares.Contains(new Square(1, 5)));
            Assert.IsTrue(Ship.squares.Contains(new Square(1, 6)));
        }
    }
}
