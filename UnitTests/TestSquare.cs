using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model
{
    [TestClass]
    public class TestSquare
    {
        [TestMethod]
        public void squareConstructorCreatesSquareWithGivenPosition()
        {
            Square S = new Square(1, 8);
            Assert.AreEqual(1,S.row);
            Assert.AreEqual(8, S.column);
        }
    }
}
