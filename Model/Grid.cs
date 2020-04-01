using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
	using Placement = IEnumerable<Square>;
	public class Grid
	{

		public readonly int Rows, Columns;
		private Square[,] squares;

		public Grid(int rows, int columns)
		{
			Rows = rows;
			Columns = columns;
			squares = new Square[Rows, Columns];

			for (int r = 0; r < Rows; r++)
			{
				for (int c = 0; c < Columns; c++)
				{
					squares[r, c] = new Square(r, c);
				}
			}
		}

		public IEnumerable<Placement> GetAvailablePlacements(int lenght)
		{
			if (lenght != 1)
			{
				return GetAwailableHorizontalPlacements(lenght).Concat(GetAwailableVerticalPlacements(lenght));
			}
			List<List<Square>> result = new List<List<Square>>();
			for (int r = 0; r < Rows; r++)
			{
				for (int c = 0; c < Columns; c++)
				{
					if (squares[r, c] != null)
						result.Add(new List<Square> { squares[r, c] });
				}
			}

			return result;
		}

		public void EliminateSquares(Placement toEliminate)
		{
			foreach (var square in toEliminate)
			{
				squares[square.Row, square.Column] = null;
			}
		}

		private IEnumerable<Placement> GetAwailableHorizontalPlacements(int lenght)
		{
			var result = new List<List<Square>>();

			for (int r = 0; r < Rows; r++)
			{
				int counter = 0;

				for (int c = 0; c < Columns; c++)
				{
					if (squares[r, c] != null)
						++counter;
					else
						counter = 0;

					if (counter >= lenght)
					{
						List<Square> seq = new List<Square>();
						for (int first = c - lenght + 1; first <= c; first++)
						{
							seq.Add(squares[r, first]);
						}

						result.Add(seq);
					}
				}
			}

			return result;
		}

		private IEnumerable<Placement> GetAwailableVerticalPlacements(int lenght)
		{
			throw new NotImplementedException();
		}

	}
}
