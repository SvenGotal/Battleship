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
            this.rows = rows;
            this.columns = columns;
        }

        public Fleet CreateFleet(IEnumerable<int> shipLengths)
        {

            for(int i = 0; i < 3; ++i)
            {
                List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));

                //1. create grid
                grid = new Grid(rows, columns);
                SquareTerminator terminator = new SquareTerminator(grid);
                Fleet fleet = new Fleet();

                //2. create fleet <--- deprecated, moved up;

                while (lengths.Count() > 0)
                {

                    //3. get available positions from grid for a given length
                    var placements = grid.GetAvailablePlacements(lengths[0]);
                    if (placements.Count() == 0)
                        break;
                    lengths.RemoveAt(0);


                    //4. select one position
                    int index = random.Next(0, placements.Count());


                    //5. forward position to fleet to create a ship
                    fleet.AddShip(placements.ElementAt(index));


                    //6. eliminate squares from grid
                    var toEliminate = terminator.ToEliminate(placements.ElementAt(index));
                    grid.EliminateSquares(toEliminate);


                    if(lengths.Count() == 0)
                    {
                        return fleet;
                    }
                }

            }

            throw new ArgumentOutOfRangeException();
            
        }



    }
}
