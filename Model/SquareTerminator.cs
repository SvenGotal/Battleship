using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class SquareTerminator
    {
        public SquareTerminator(Grid grid)
        {
            this.grid = grid;
        }

        public IEnumerable<Square> ToEliminate(IEnumerable<Square> squares)
        {
            int left = squares.First().Column;
            if (left > 0)
                --left;

            int top = squares.First().Row;
            if (top > 0)
                --top;

            int right = squares.Last().Column + 1;
            if (right < grid.Columns)
                ++right;

            int bottom = squares.Last().Row + 1;
            if (bottom < grid.Rows)
                ++bottom;

            var toEliminate = new List<Square>();
            for (int r = top; r < bottom; ++r)
            {
                for (int c = left; c < right; ++c)
                {
                    toEliminate.Add(new Square(r, c));
                }
            }
            return toEliminate;
        }

        private readonly Grid grid;
    }
}
