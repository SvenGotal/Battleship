using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class grid
    {
        public grid(int rw, int cl)
        {
            Rw = rw;
            Cl = cl;
            squares = new square[Rw,Cl];
            for (int r = 0; r < Rw; ++r)
            {
                for(int c = 0; c < Cl; ++c)
                {
                    squares[r, c] = new square(r, c);
                }
            }
        }
        public readonly int Rw;
        public readonly int Cl;
        public IEnumerable<IEnumerable<square>> GetAvaliablePlacements(int len)
        {
            throw new NotImplementedException();
        }
        private square[,] squares;
    }
}
