using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    class Shipwright
    {
        public Shipwright(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        public Fleet CreateFleet(IEnumerable<int> shipLengths)
        {
            for (int i = 0; i < 3; ++i)
            {
                List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));

                grid = new Grid(rows, columns); // create grid    
                SquareTerminator terminator = new SquareTerminator(grid);
                Fleet fleet = new Fleet(); //create fleet

                while (lengths.Count > 0)
                {
                    var placements = grid.GetAvailablePlacements(lengths[0]); //get available positions from grid for given length
                    if (placements.Count() == 0)
                        break;
                    lengths.RemoveAt(0);
                    int index = random.Next(0, placements.Count()); //select one position
                    fleet.AddShip(placements.ElementAt(index)); //forward position to fleet to create ship      
                    var toEliminate = terminator.ToEliminate(placements.ElementAt(index)); // eliminate squares from grid
                    grid.EliminateSquares(toEliminate);
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
