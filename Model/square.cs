using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Square
    {
        public Square(int r, int c)
        {
            row = r;
            column = c;
        }
        public readonly int row;
        public readonly int column;
    }
}
