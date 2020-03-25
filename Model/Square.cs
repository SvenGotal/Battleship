using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.oom.Battleship.Model
{
    public class Square
    {
        public Square(int rows,int columns)
        {

            Rows = rows;
            Columns = columns;
        }

        public readonly int Rows;
        public readonly int Columns;
    }
}
