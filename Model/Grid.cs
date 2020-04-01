using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    using Placement = IEnumerable<Square>;
    public class Grid
    {

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            squares = new Square[rows, columns];
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    squares[r, c] = new Square(r, c);
                }
            }
        }

        public readonly int Rows;
        public readonly int Columns;

        public IEnumerable<Placement> GetAvailablePlacements(int length)
        {
            if (length != 1)
            {
                return GeAvailableHorizontalPlacements(length).Concat(GetAvailableVerticalPlacements(length));
            }
            var result = new List<List<Square>>();
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    if (squares[r, c] != null)
                    {
                        result.Add(new List<Square> { squares[r, c] });
                    }
                }
            }
            return GeAvailableHorizontalPlacements(length).Concat(GetAvailableVerticalPlacements(length));
        }

        private IEnumerable<Placement> GeAvailableHorizontalPlacements(int length)
        {
            var result = new List<List<Square>>();
            for (int r = 0; r < Rows; r++)
            {
                int counter = 0;
                for (int c = 0; c < Columns; c++)
                {
                    if (squares[r, c] != null)
                    {
                        ++counter;
                    }
                    else
                    {
                        counter = 0;
                    }
                    if (counter >= length)
                    {
                        var seq = new List<Square>();
                        for (int i = c - length + 1; i <= c; i++)
                        {
                            seq.Add(squares[r, i]);
                        }
                        result.Add(seq);
                    }
                }
            }
            return result;
        }
        private IEnumerable<Placement> GetAvailableVerticalPlacements(int length)
        {
            throw new NotImplementedException();
        }

        public void EliminateSqure(Placement toEliminate)
        {
            foreach (var item in toEliminate)
            {
                squares[item.Row, item.Column] = null;
            }
        }

        private Square[,] squares;
    }
}
