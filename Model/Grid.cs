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
		public Grid(int rows, int columns)
		{
			Rows = rows;
			Columns = columns;
		}

		public IEnumerable<IEnumerable<Square>> GetAvailablePlacements(int lenght)
		{
			throw new NotImplementedException();
		}

	}
}
