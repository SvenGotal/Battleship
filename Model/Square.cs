using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.oom.Battleship.Model
{
    public class Square:IEquatable<Square>
    {
        public Square(int rows,int columns)
        {

            Rows = rows;
            Columns = columns;
        }

        public readonly int Rows;
        public readonly int Columns;

        public bool Equals(Square other)
        {
            return Rows== other.Rows && Columns == other.Columns;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Square)obj);
        }

        public override int GetHashCode()
        {
            return Rows ^ Columns;
        }
    }
}
