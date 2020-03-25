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
		}
		public IEnumerable<IEnumerable<Square>> GetAvailablePlacments(int length)
		{
			throw new NotImplementedException();
		}
		public readonly int Rows;
		public readonly int Cols;
	}
}
