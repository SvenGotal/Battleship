using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
	public class Grid
	{

		public readonly int Rows, Columns;
		private Square[,] squares;

		public Grid(int rows, int columns)
		{
			Rows = rows;
			Columns = columns;
			squares = new Square[Rows, Columns];

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < columns; c++)
				{
					squares[r, c] = new Square(r, c);
				}
			}
		}

		public IEnumerable<IEnumerable<Square>> GetAvailablePlacements(int lenght)
		{
			throw new NotImplementedException();
		}

	}
}
