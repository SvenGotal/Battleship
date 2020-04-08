using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.Oom.Battleship.Model
{
    public class SquareTerminator
    {
        public SquareTerminator(Grid grid)
        {
            this.grid = grid;
        }

        public IEnumerable<Square> toEliminate(IEnumerable<Square> shipSquares)
        {

         

            throw new NotImplementedException();
        }

        private readonly Grid grid;
    }
}
