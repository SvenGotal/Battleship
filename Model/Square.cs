using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Square
    {
        public Square(int row,int col)
        {
            Row = row;
            Col = col;
        }
        public readonly int Row;
        public readonly int Col;
    }
}
