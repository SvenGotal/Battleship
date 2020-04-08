using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.Oom.Battleship.Model
{
    public class ShipWright
    {

        public ShipWright(int rows,int columns)
        {
            this.rows = rows;
            this.columns = columns;
 
        }

        public Fleet CreateFleet(IEnumerable<int> shipLengths)
        {

            List<int> lengths = new List<int>(shipLengths);

            //grid = new Grid(rows, columns);

            Fleet fleet = new Fleet();

            




            throw new NotImplementedException();
        }

      

        private readonly int rows;
            private readonly int columns;


    }
}
