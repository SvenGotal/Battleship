using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestShip
    {
        [TestMethod]
        public void ConstructorCreatesShipFromSquaresProvided()
        {
            var ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
            Assert.IsTrue(ship.Squares.Contains(new Square(1, 4)));
            Assert.IsTrue(ship.Squares.Contains(new Square(1, 5)));
            Assert.IsTrue(ship.Squares.Contains(new Square(1, 6)));
        }

        [TestMethod]
        public void HitMethodOnFirstSquareReturnsHitResultHit()
        {
            {
                var ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var hitResult = ship.Hit(new Square(1, 5));
                Assert.AreEqual(ShipHitResult.Hit, hitResult);
            }

            {
                var ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var hitResult = ship.Hit(new Square(1, 4));
                Assert.AreEqual(ShipHitResult.Hit, hitResult);
            }

            {
                var ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var hitResult = ship.Hit(new Square(1, 6));
                Assert.AreEqual(ShipHitResult.Hit, hitResult);
            }
        }

        [TestMethod]
        public void HitMethodOnMissedSquareReturnsHitResultMissed()
        {
            {
                var ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                var hitResult = ship.Hit(new Square(2, 5));
                Assert.AreEqual(ShipHitResult.Missed, hitResult);
            }
        }

        [TestMethod]
        public void HitMethodOnLastSquareReturnsHitResultSunken()
        {
            {
                var ship = new Ship(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
                _ = ship.Hit(new Square(1, 5));
                _ = ship.Hit(new Square(1, 4));
                var hitResult = ship.Hit(new Square(1, 6));
                Assert.AreEqual(ShipHitResult.Sunken, hitResult);
            }
        }
    }
}
