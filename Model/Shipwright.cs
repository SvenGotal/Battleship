using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.BattleShip.Model
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
            for(int i = 0; i < 3; ++i)
            {


                List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));
                grid = new Grid(rows, columns);
                SquareTerminator terminator = new SquareTerminator(grid);
                Fleet fleet = new Fleet();

                while (lengths.Count > 0)
                {
                    var placements = grid.GetAvailablePlacements(lengths[0]);
                    if (placements.Count() == 0)
                    {
                        break;
                    }
                    lengths.RemoveAt(0);
                    var index = random.Next(0, placements.Count());
                    fleet.AddShip(placements.ElementAt(index));

                    var toEliminate = terminator.toEliminate(placements.ElementAt(index));
                    grid.EliminateSquares(toEliminate);

                    if(lengths.Count == 0)
                    {
                        return fleet;
                        fleetComplete = true;
                    }
                }
            }
            throw new ArgumentOutOfRangeException();
        }

        private Grid grid;
        private readonly int rows;
        private readonly int columns;
        private Random random = new Random();
    }
}
