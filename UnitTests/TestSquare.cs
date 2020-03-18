using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestSquare
    {
        [TestMethod]
        public void SquareConstructorCreatesSquareWithGivenPosition()
        {
            Square square = new Square(1, 8);
            Assert.AreEqual(1,square.Row);
            Assert.AreEqual(8, square.Column);
        }
    }
}
