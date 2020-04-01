using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    using placement = IEnumerable<Square>;
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
        public void eliminateSquares(placement toElim)
        {
            foreach(var sq in toElim)
            {
                squares[sq.row, sq.column]=null;
            }
        }
        public readonly int Rw;
        public readonly int Cl;
        public IEnumerable<placement> GetAvailablePlacements(int len)
        {
            return GetAvailableHorizontalPlacements(len).Concat(GetAvailableVerticalPlacements(len));
        }
        private IEnumerable<placement> GetAvailableHorizontalPlacements(int len)
        {
            var res = new List<List<Square>>();
            for(int r = 0; r < Rw; ++r)
            {
                int cnt = 0;
                for(int c = 0; c < Cl; ++c)
                {
                    if (squares[r, c] != null)
                    {
                        ++cnt;
                    }
                    else
                    {
                        cnt = 0;
                    }
                    if (cnt >= len)
                    {
                        List<Square> seq = new List<Square>();
                        for(int f = c - len + 1;f <= c;++f)
                        {
                            seq.Add(squares[r, f]);
                        }
                        res.Add(seq);
                    }
                }
            }
            return res;
        }
        private IEnumerable<placement> GetAvailableVerticalPlacements(int len)
        {
            throw new NotImplementedException();
        }
        private Square[,] squares;
    }
}
