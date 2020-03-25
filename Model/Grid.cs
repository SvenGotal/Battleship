using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
	public class Grid
	{
		public Grid(int rows, int cols)
		{
			Rows = rows;
			Cols = cols;
			squares = new Square[Rows, Cols];
			for (int r = 0; r < Rows; ++r)
			{
				for (int c = 0; r < Cols; ++c)
					squares[r, c] = new Square(r, c);
			}
		}
		public IEnumerable<IEnumerable<Square>> GetAvailablePlacments(int length)
		{
			throw new NotImplementedException();
		}
		public void EliminateSquares(IEnumerable<Square> squares)
		{
			throw new NotImplementedException();
		}
		public readonly int Rows;
		public readonly int Cols;

		private Square[,] squares;
	}
}
