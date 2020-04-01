﻿using System;
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
        public IEnumerable<placement> GetAvailablePlacements(int len)
        {
            if (len != 1)
            {
                return GetAvailableHorizontalPlacements(len).Concat(GetAvailableVerticalPlacements(len));
            }
            List<List<Square>> res = new List<List<Square>>();
            for (int r = 0; r < Rw; ++r)
            {
                for (int c = 0; c < Cl; ++c)
                {
                    res.Add(new List<Square> { squares[r, c] });
                }
            }
            return res;
        }
        public void eliminateSquares(placement toElim)
        {
            foreach (var sq in toElim)
            {
                squares[sq.row, sq.column] = null;
            }
        }
                    
        private IEnumerable<placement> GetAvailableHorizontalPlacements(int len)
        {
            var res = new List<List<Square>>();
            for(int r = 0; r < Rw; ++r)
            {
                limitedQueue<Square> pass = new limitedQueue<Square>(len);
                for (int c = 0; c < Cl; ++c)
                {

                    if (squares[r, c] != null)
                    {
                        pass.Enqueue(squares[r, c]);
                    }
                    else
                    {
                        pass.Clear();
                    }
                    if (pass.Count == len)
                    {
                        res.Add(pass.ToList());
                    }
                }
            }
            return res;
        }
        private IEnumerable<placement> GetAvailableVerticalPlacements(int len)
        {
            var res = new List<List<Square>>();
            for (int c = 0; c < Cl; ++c)
            {
                limitedQueue<Square> pass = new limitedQueue<Square>(len);
                for (int r = 0; r < Rw; ++r)
                {
                    if (squares[r, c] != null)
                    {
                        pass.Enqueue(squares[r, c]);
                    }
                    else
                    {
                        pass.Clear();
                    }
                    if (pass.Count == len)
                    {
                        res.Add(pass.ToList());
                    }
                }
            }
            return res;
        }
        private Square[,] squares;
        public readonly int Rw;
        public readonly int Cl;

    }
}
