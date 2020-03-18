using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestSquares
    {
        [TestMethod]
        public void SquareConstructorCreateSquareWithGivenPosition()
        {
            Square s = new Square(1, 8);
            Assert.AreEqual(1, s.Row);
            Assert.AreEqual(8, s.Col);
        }
    }
}

