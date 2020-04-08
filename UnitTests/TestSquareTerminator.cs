﻿using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestSquareTerminator
    {
        [TestMethod]
        
            
            public void ToEliminateReturns18SquaresArroundTheShipIn4_3to4_6()
            {
                Grid grid = new Grid(10, 10);
                SquareTerminator terminator = new SquareTerminator(grid);
                var toEliminate = terminator.ToEliminate(new List<Square> { new Square(4, 3), new Square(4, 4), new Square(4, 5), new Square(4, 6) });
                Assert.AreEqual(18, toEliminate.Count());
                Assert.IsTrue(toEliminate.Contains(new Square(3, 2)));
                Assert.IsTrue(toEliminate.Contains(new Square(5, 2)));
                Assert.IsTrue(toEliminate.Contains(new Square(3, 7)));
                Assert.IsTrue(toEliminate.Contains(new Square(5, 7)));
            }

        [TestMethod]
        public void ToEliminateReturns8SquaresArroundTheShipIn0_3to0_4()
        {
            Grid grid = new Grid(10, 10);
            SquareTerminator terminator = new SquareTerminator(grid);
            var toEliminate = terminator.ToEliminate(new List<Square> { new Square(0, 3), new Square(0, 4) });
            Assert.AreEqual(8, toEliminate.Count());
            Assert.IsTrue(toEliminate.Contains(new Square(0, 2)));
            Assert.IsTrue(toEliminate.Contains(new Square(1, 2)));
            Assert.IsTrue(toEliminate.Contains(new Square(1, 5)));
            Assert.IsTrue(toEliminate.Contains(new Square(0, 5)));
        }

        [TestMethod]
        public void ToEliminateReturns6SquaresArroundTheShipIn0_0to0_1()
        {
            Grid grid = new Grid(10, 10);
            SquareTerminator terminator = new SquareTerminator(grid);
            var toEliminate = terminator.ToEliminate(new List<Square> { new Square(0, 0), new Square(0, 1) });
            Assert.AreEqual(6, toEliminate.Count());
            Assert.IsTrue(toEliminate.Contains(new Square(0, 0)));
            Assert.IsTrue(toEliminate.Contains(new Square(1, 0)));
            Assert.IsTrue(toEliminate.Contains(new Square(1, 2)));
            Assert.IsTrue(toEliminate.Contains(new Square(0, 2)));
        }

        [TestMethod]
        public void ToEliminateReturns6SquaresArroundTheShipIn8_9to9_9()
        {
            Grid grid = new Grid(10, 10);
            SquareTerminator terminator = new SquareTerminator(grid);
            var toEliminate = terminator.ToEliminate(new List<Square> { new Square(8, 9), new Square(9, 9) });
            Assert.AreEqual(6, toEliminate.Count());
            Assert.IsTrue(toEliminate.Contains(new Square(7, 8)));
            Assert.IsTrue(toEliminate.Contains(new Square(7, 9)));
            Assert.IsTrue(toEliminate.Contains(new Square(9, 8)));
            Assert.IsTrue(toEliminate.Contains(new Square(9, 9)));
        }
    }
    
}
