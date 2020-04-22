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
            for (int i=0; i<3; ++i)
            {
                Fleet fleet = PlaceShips(shipLengths);
                    if (fleet != null)
                    return fleet;
            }
            throw new ArgumentOutOfRangeException();
        }
        private readonly int rows;
        private readonly int columns;
        private Grid grid;
        private Random random = new Random();
    }
}
