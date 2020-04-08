using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Shipwright
    {
        public Shipwright(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        public Fleet CreateFleet(IEnumerable<int> shipLengths)
        {
            bool fleetComplete = false;
            Fleet fleet = null;
            do
            {
                List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));
                grid = new Grid(rows, columns);
                fleet = new Fleet();
                while (lengths.Count > 0)
                {
                    var placements = grid.GetAvailablePlacements(lengths[0]);
                    lengths.Remove(0);
                    int index = random.Next(0, placements.Count());
                    fleet.AddShip(placements.ElementAt(index));
                    // 6. eliminate squares from grid
                    if (lengths.Count == 0)
                        return fleet;
                }
            } while (fleetComplete == false);
            return fleet;
        }
        private readonly int rows;
        private readonly int columns;
        private Grid grid;
        private Random random = new Random();
    }
}
