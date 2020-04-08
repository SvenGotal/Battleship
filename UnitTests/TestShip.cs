﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestShip
    {
        [TestMethod]
        public void ConstructorCreatesShipFromSquaresProvided()
        {
            Ship ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
            Assert.IsTrue(ship.Squares.Contains(new Square(1,4)));
            Assert.IsTrue(ship.Squares.Contains(new Square(1,5)));
            Assert.IsTrue(ship.Squares.Contains(new Square(1,6)));
        }
    }
}
