using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.BattleShip.Model
{
    using Placement = IEnumerable<Square>;

   public class Grid
    {
        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            this.squares = new Square[this.Rows, this.Columns];
            for (int r = 0; r < this.Rows; ++r)
            {
                for (int c = 0; c < this.Columns; ++c)
                {
                    squares[r, c] = new Square(r, c);
                }
            }
        }

        public IEnumerable<IEnumerable<Square>> GetAvailablePlacements(int length)
        {
            return GetAvailableHorizontalPlacement(length).Concat(GetAvailableVerticalPlacement(length));
        }

        public void EliminateSquares(Placement eliminate)
        {
            foreach(var square in eliminate)
            {
                squares[square.row, square.column] = null;
            }

            
            
        }

        private IEnumerable<Placement> GetAvailableVerticalPlacement(int length)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Placement> GetAvailableHorizontalPlacement(int length)
        {
            var result = new List<List<Square>>();
            for(int r = 0; r < Rows; ++r)
            {
                int counter = 0;
                for(int c = 0; c < Columns; ++c)
                {
                    if(squares[r, c] != null)
                    {
                        ++counter;
                    }
                    else
                    {
                        counter = 0;
                    }
                    if(counter >= length)
                    {
                        List<Square> sequence = new List<Square>();
                        for(int first = c - length + 1; first <= c; ++first)
                        {
                            sequence.Add(squares[r, first]);
                            
                        }
                        result.Add(sequence);
                    }
                }
            }
            return result;
        } 

        public readonly int Rows;
        public readonly int Columns;
        private Square[,] squares;
    }
}
