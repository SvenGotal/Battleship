using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestSquare
    {
        [TestMethod]
        public void squareConstructorCreatesSquareWithGivenPosition()
        {
            square S = new square(1, 8);
            Assert.AreEqual(1,S.row);
            Assert.AreEqual(8, S.column);
        }
    }
}
