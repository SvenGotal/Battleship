using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Shipwright
    {

        private readonly int rows;
        private readonly int columns;
        private Grid grid;
        private Random random = new Random();

        public Shipwright(int rows, int columns)
        {
            this.columns = columns;
            this.rows = rows;
        }

        public Fleet CreateFleet(IEnumerable<int> shipLengths)
        {

            Fleet fleet = null;
            for (int i = 0; i < 3; ++i)
            {

                List<int> lengths = new List<int>(shipLengths.OrderByDescending(l => l));
                grid = new Grid(rows, columns);
                fleet = new Fleet();

                while (lengths.Count > 0)
                {

                    var placements = grid.GetAvailablePlacements(lengths[0]);

                    if (placements.Count() == 0)
                        break;

                    lengths.Remove(0);
                    int index = random.Next(0, placements.Count());
                    fleet.AddShip(placements.ElementAt(index));
                    // 6. Eliminate squares from grid

                    if (lengths.Count == 0)
                        return fleet;
                }
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
