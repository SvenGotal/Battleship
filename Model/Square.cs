using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.BattleShip.Model
{
    public class Square
    {
        public Square(int row, int column)
        {
            this.row = row;
            this.column = column;
            this.squares = new Square[this.row, this.column];
            for(int r = 0; r < this.row; ++r)
            {
                for(int c = 0; c < this.column; ++c)
                {
                    squares[r, c] = new Square(r, c);
                }
            }
        }
        public readonly int row;
        public readonly int column;

        private Square[,] squares;
    }
}
