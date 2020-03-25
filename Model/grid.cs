using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Grid
    {
        public Grid(int rw, int cl)
        {
            Rw = rw;
            Cl = cl;
            squares = new Square[Rw,Cl];
            for (int r = 0; r < Rw; ++r)
            {
                for(int c = 0; c < Cl; ++c)
                {
                    squares[r, c] = new Square(r, c);
                }
            }
        }
        public void eliminateSquares(IEnumerable<Square> squares)
        {
            throw new NotImplementedException();
        }
        public readonly int Rw;
        public readonly int Cl;
        public IEnumerable<IEnumerable<Square>> GetAvaliablePlacements(int len)
        {
            throw new NotImplementedException();
        }
        private Square[,] squares;
    }
}
