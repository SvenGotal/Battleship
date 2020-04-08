﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestSquareTerminator
    {
        [TestMethod]
        public void ToEliminateReturns18SquaresAroundTheShip4_3To4_6()
        {
            var grid = new Grid(10, 10);
            var squareTerminator = new SquareTerminator(grid);
            var toEliminate = squareTerminator.ToEliminate(new List<Square> { new Square(4, 3), new Square(4, 4), new Square(4, 5), new Square(4, 6) });
            Assert.AreEqual(18, toEliminate.Count());

            Assert.IsTrue(toEliminate.Contains(new Square(3, 2)));
            Assert.IsTrue(toEliminate.Contains(new Square(5, 2)));
            Assert.IsTrue(toEliminate.Contains(new Square(3, 7)));
            Assert.IsTrue(toEliminate.Contains(new Square(5, 7)));
        }

        [TestMethod]
        public void ToEliminateReturns8SquaresAroundTheShip0_3To0_4()
        {
            var grid = new Grid(10, 10);
            var squareTerminator = new SquareTerminator(grid);
            var toEliminate = squareTerminator.ToEliminate(new List<Square> { new Square(0, 3), new Square(0, 4) });
            Assert.AreEqual(8, toEliminate.Count());

            Assert.IsTrue(toEliminate.Contains(new Square(0, 2)));
            Assert.IsTrue(toEliminate.Contains(new Square(1, 2)));
            Assert.IsTrue(toEliminate.Contains(new Square(1, 5)));
            Assert.IsTrue(toEliminate.Contains(new Square(0, 5)));
        }

        [TestMethod]
        public void ToEliminateReturns6SquaresAroundTheShip0_0To0_1()
        {
            var grid = new Grid(10, 10);
            var squareTerminator = new SquareTerminator(grid);
            var toEliminate = squareTerminator.ToEliminate(new List<Square> { new Square(0, 0), new Square(0, 1) });
            Assert.AreEqual(6, toEliminate.Count());

            Assert.IsTrue(toEliminate.Contains(new Square(0, 0)));
            Assert.IsTrue(toEliminate.Contains(new Square(1, 0)));
            Assert.IsTrue(toEliminate.Contains(new Square(0, 2)));
            Assert.IsTrue(toEliminate.Contains(new Square(1, 2)));
        }

        [TestMethod]
        public void ToEliminateReturns6SquaresAroundTheShip8_9To9_9()
        {
            var grid = new Grid(10, 10);
            var squareTerminator = new SquareTerminator(grid);
            var toEliminate = squareTerminator.ToEliminate(new List<Square> { new Square(8, 9), new Square(9, 9) });
            Assert.AreEqual(6, toEliminate.Count());

            Assert.IsTrue(toEliminate.Contains(new Square(7, 8)));
            Assert.IsTrue(toEliminate.Contains(new Square(7, 9)));
            Assert.IsTrue(toEliminate.Contains(new Square(9, 8)));
            Assert.IsTrue(toEliminate.Contains(new Square(9, 9)));
        }
    }
}
