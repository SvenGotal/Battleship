using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace Vsite.Oom.Battleship.Model.UnitTests
{
	[TestClass]
	public class SquareTerminatorTest
	{
		[TestMethod]
		public void ToEliminateReturnsSquaresAroundTheShip4_3To4_6()
		{
			Grid grid = new Grid(10, 10);
			SquareTerminator terminator = new SquareTerminator(grid);
			var toEliminate = terminator.ToEliminate(new List<Square> { new Square(4,3),new Square(4,4),new Square(4,5),
				new Square(4,6) });

			Assert.AreEqual(18, toEliminate.Count());
			Assert.IsTrue(toEliminate.Contains(new Square(3, 2)));
			Assert.IsTrue(toEliminate.Contains(new Square(5, 2)));
			Assert.IsTrue(toEliminate.Contains(new Square(3, 7)));
			Assert.IsTrue(toEliminate.Contains(new Square(5, 7)));
		}
	}
}
