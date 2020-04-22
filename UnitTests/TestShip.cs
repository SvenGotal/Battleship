using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestShip
    {
        [TestMethod]
        public void ConstroctorCreatesShipFromSquaresProvided()
        {
            Ship ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
            Assert.IsTrue(ship.squares.Contains(new Square(1, 4)));
            Assert.IsTrue(ship.squares.Contains(new Square(1, 5)));
            Assert.IsTrue(ship.squares.Contains(new Square(1, 6)));
        }

        [TestMethod]
        public void HitMethodOnFirstSquareReturnsHitResult()
        {

            {
                Ship ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var result = ship.Hit(new Square(1, 5));
                Assert.AreEqual(HitResult.Hit, result);

            }

            {
                Ship ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var result = ship.Hit(new Square(1, 4));
                Assert.AreEqual(HitResult.Hit, result);

            }

            {
                Ship ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var result = ship.Hit(new Square(1, 6));
                Assert.AreEqual(HitResult.Hit, result);

            }


        }

        [TestMethod]
        public void HitMethodOnFirstSquareReturnsHitResultMissed()
        {

            {
                Ship ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var result = ship.Hit(new Square(2, 5));
                Assert.AreEqual(HitResult.Missed, result);

            }

        }


        [TestMethod]
        public void HitMethodOnFirstSquareReturnsHitResultSunken()
        {

            {
                Ship ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var result = ship.Hit(new Square(1, 5));
                result = ship.Hit(new Square(1, 4));
                result = ship.Hit(new Square(1, 6));
                Assert.AreEqual(HitResult.Sunken, result);

            }

        }
    }
}
