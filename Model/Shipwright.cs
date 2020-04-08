using System;
using System.Collections.Generic;
using System.Linq;

namespace Vsite.Oom.Battleship.Model
{
    public class Shipwright
    {
        public Shipwright(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }

        public Fleet CreateFleet(IEnumerable<int> shipLenths)
        {
            Fleet fleet = new Fleet();

            for( int i = 0; i < 3; ++i)
            {
                List<int> lenghts = new List<int>(shipLenths.OrderByDescending(s => s));
                grid = new Grid(rows, columns);

                while (lenghts.Count > 0)
                {
                    var placements = grid.GetAvailablePlacements(lenghts[0]);
                    if (placements.Count() == 0) break;

                    lenghts.RemoveAt(0);

                    int index = random.Next(0, placements.Count());
                    fleet.AddShip(placements.ElementAt(index));

                    if (lenghts.Count() == 0) return fleet;
                }
            }
            throw new ArgumentOutOfRangeException(); ;
        }

        private readonly int rows;
        private readonly int columns;
        private Grid grid;
        public Random random = new Random();
    }
}
