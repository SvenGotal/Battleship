using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class shipwright
    {
        public shipwright(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        public fleet CreateFleet(IEnumerable<int> shipLengths) {
            for(int i = 0;i<3;++i)
            {
                List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));
                grid = new Grid(rows, columns);
                squareTerminator terminator = new squareTerminator(grid);
                fleet Fleet = new fleet();
                while (lengths.Count() > 0)
                {
                    var placements = grid.GetAvailablePlacements(lengths[0]);
                    if (placements.Count() == 0) break;
                    lengths.RemoveAt(0);
                    int index = rand.Next(0, placements.Count());
                    Fleet.addShip(placements.ElementAt(index));
                    var toElimiante = terminator.ToEliminate(placements.ElementAt(index));
                    grid.eliminateSquares(toElimiante);
                    if (lengths.Count() == 0) return Fleet;
                }
            }
            throw new ArgumentOutOfRangeException();
        }
        private readonly int rows;
        private readonly int columns;
        private Grid grid;
        private Random rand = new Random();
    }
}
