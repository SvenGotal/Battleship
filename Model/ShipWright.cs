using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.oom.Battleship.Model
{
    public class ShipWright
    {

        public ShipWright(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }

        public Fleet CreateFleet(IEnumerable<int> shipLengths)
        {
            for (int i = 0; i < 3; ++i)
            {
                List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));

                grid = new Grid(rows, columns);
                Fleet fleet = new Fleet();

                while (lengths.Count() > 0)
                {
                    var placements = grid.GetAvailablePlacements(lengths[0]);
                    if (placements.Count() == 0)
                        break;
                    lengths.Remove(0);
                    int index = random.Next(0, placements.Count());
                    fleet.AddShip(placements.ElementAt(index));
                    //6. eliminate squares from grid

                    if (lengths.Count == 0)
                        return fleet;
                }
            }
            throw new ArgumentOutOfRangeException();
        }

        private readonly int rows;
        private readonly int columns;
        private Grid grid;
        private Random random = new Random();
    }
}
