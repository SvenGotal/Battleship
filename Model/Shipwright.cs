using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Shipwright
    {
        public Shipwright(int rows, int columns) {
            this.rows = rows;
            this.columns = columns;
        }
        public Fleet CreateFleet(IEnumerable<int> shipLenght) {

           for(int i = 0; i<3;++i)
            {

                List<int> lenghts = new List<int>(shipLenght.OrderByDescending(x => x));

                grid = new Grid(rows, columns);

                Fleet fleet = new Fleet();

                while (lenghts.Count > 0)
                {
                    var placments = grid.GetAvailablePlacements(lenghts[0]);
                    if (placments.Count() == 0)
                        break;
                    lenghts.Remove(0);

                    int index = random.Next(0, placments.Count());

                    fleet.AddShip(placments.ElementAt(index));
                    // 6. eliminate squares form grid

                    if (lenghts.Count == 0)
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
