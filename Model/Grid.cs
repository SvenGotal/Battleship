using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{ using Placement = IEnumerable<Square>;
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
		public IEnumerable<Placement> GetAvailablePlacments(int length)
		{
			if(length != 1)
			{
				List<List<Square>> result = new List<List<Square>>();
				for (int r = 0; r < Rows; ++r)
				{
					for (int c = 0; r < Cols; ++c)
						if (squares[r, c] != null)
							result.Add(new List<Square> { squares[r, c] });
				}
				return result;
			}
			return GetAvailableHorizontalPlacements(length).Concat(GetAvailableVerticalPlacements(length));
		}
		public void EliminateSquares(Placement toEliminate)
		{
			foreach (var square in toEliminate)
				squares[square.Row, square.Col] = null;


		}
		private IEnumerable<Placement> GetAvailableHorizontalPlacements(int length)
		{
			var result = new List<List<Square>>();
			for (int r = 0; r < Rows; ++r)
			{
				LimitedQueue<Square> passed = new LimitedQueue<Square>(length);
				for (int c = 0; c < Cols; ++c)
				{
					if (squares[r, c] != null)
						passed.Enqueue(squares[r, c]);
					else
						passed.Clear();
					if (passed.Count == length)
					{
						result.Add(passed.ToList());
					}
				}
			}
					
			return result;
		}
		private IEnumerable<Placement> GetAvailableVerticalPlacements(int length)
		{
			return new List<Placement>();
		}


		public readonly int Rows;
		public readonly int Cols;

		private Square[,] squares;
	}
}
	

