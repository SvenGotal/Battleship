﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.Oom.Battleship.Model
{
    public class Grid
    {
        public Grid(int rows,int columns)
        {
            Rows = rows;
            Columns = columns;
            sqaures = new Square[Rows, Columns];
            for(int r = 0; r < Rows; ++r)
            {
                for (int c = 0; c < Columns; ++c) {
                    sqaures[r, c] = new Square(r, c);
                }
            }
        }

        public readonly int Rows;
        public readonly int Columns;

        public IEnumerable<IEnumerable<Square>> GetAvailablePlacements(int length)
        {
            throw new NotImplementedException();
        }

        public void EliminateSquares(IEnumerable<Square> squares)
        {
            throw new NotImplementedException();

        }

        private Square[,] sqaures;
    }


}
