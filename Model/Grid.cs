﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    using Placement = IEnumerable<Square>;
    public class Grid
    {
        public Grid(int rows,int columns)
        {
            Rows = rows;
            Columns = columns;
            squares = new Square[Rows, Columns];
            for(int r = 0; r < Rows; ++r)
            {
                for(int c = 0; c < Columns; ++c)
                {
                    squares[r, c] = new Square(r, c);
                }
            }
        }
        public IEnumerable<Placement> GetAvailablePlacements(int Length)
        {
            
            return GetAvailableHorizontalPlacements(Length).Concat(GetAvailableVerticalPlacements(Length)) ;
        }
        public void EliminateSquares(Placement toEliminate)
        {
            foreach(var square in toEliminate)
            {
                squares[square.Row, square.Column] = null;
            }
        }
        private IEnumerable<Placement>GetAvailableHorizontalPlacements(int Length)
        {
            var result = new List<List<Square>>();
            for(int r = 0; r < Rows; ++r)
            {
                int counter = 0;
                for(int c = 0; c < Columns; ++c)
                {
                    if (squares[r, c] != null)
                    {
                        ++counter;
                    }
                    else
                    {
                        counter = 0;
                    }
                    if (counter >= Length)
                    {
                        List < Square >seq= new List<Square>();
                        for(int first = c - Length + 1; first <= c; ++first)
                        {
                            seq.Add(squares[r, first]);
                        }
                        result.Add(seq);
                    }
                }
            }
            return result;
        }
        private IEnumerable<Placement> GetAvailableVerticalPlacements(int Length)
        {
            var result = new List<List<Square>>();
            for (int c = 0; c < Columns; ++c)
            {
                int counter = 0;
                for (int r = 0; r < Rows; ++r)
                {
                    if (squares[r, c] != null)
                    {
                        ++counter;
                    }
                    else
                    {
                        counter = 0;
                    }
                    if (counter >= Length)
                    {
                        List<Square> seq = new List<Square>();
                        for (int first = r - Length + 1; first <= r; ++first)
                        {
                            seq.Add(squares[first, c]);
                        }
                        result.Add(seq);
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
