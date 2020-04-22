using System;

namespace Vsite.Oom.Battleship.Model
{
    public class Square : IEquatable<Square>
    {
        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public readonly int Row;
        public readonly int Column;

        public bool Equals(Square other)
        {
            return other != null && Row == other.Row && Column == other.Column;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            return Equals((Square)obj);
        }

        public override int GetHashCode()
        {
            return Row ^ Column;
        }

        public static bool operator ==(Square first, Square second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(Square first, Square second)
        {
            return !(first == second);
        }
    }
}
