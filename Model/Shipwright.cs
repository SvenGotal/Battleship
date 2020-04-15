using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Shipwright
    {
        public Shipwright(int rows, int colums)
        {
            this.rows=rows;
            this.colums=colums;

        }
        public Fleet CreateFleet(IEnumerable<int> shipLengths)
        {

            for (int i = 0; i < 3; ++i)
            {
               
                    List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));

                    // 1. create grid
                    grid = new Grid(rows, colums);
                SquareTerminator terminator = new SquareTerminator(grid);
                    // 2. create fleet
                    Fleet fleet = new Fleet();
                    // 3. get available positions from grid for a given len

                    while (lengths.Count > 0)
                    {
                        var placements = grid.GetAvailablePlacements(lengths[0]);
                   
                        if (placements.Count() == 0)
                            break;
                        lengths.RemoveAt(0);
                        // 4. select one position
                        int index = random.Next(0, placements.Count());

                        // 5. forward position to fleet to create a ship
                        fleet.AddShip(placements.ElementAt(index));
                    // 6. eliminate squares from the grid

                    var toEliminate = terminator.ToEliminate(placements.ElementAt(index));
                    grid.EliminateSquares(toEliminate);


                        if (lengths.Count == 0)
                            return fleet;
                    }  
            }
            throw new ArgumentOutOfRangeException();
        }

        private readonly int rows;
        private readonly int colums;
        private Grid grid;
        private Random random = new Random();
    }
}
