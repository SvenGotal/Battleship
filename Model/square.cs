﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Square : IEquatable<Square>
    {
        public Square(int r, int c)
        {
            row = r;
            column = c;
        }
        public readonly int row;
        public readonly int column;

        public bool Equals(Square other)
        {
            return row == other.row && column == other.column;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(obj.GetType() != GetType())
            {
                return false;
            }
            return Equals((Square)obj);
        }

        public override int GetHashCode()
        {
            return row ^ column;
        }
    }
}
