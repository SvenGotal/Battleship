using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.BattleShip.Model
{
    using Placement = IEnumerable<Square>;

    public class Square
    {
        public Square(int row, int column)
        {
            this.row = row;
            this.column = column;
            
            
        }

        
        public readonly int row;
        public readonly int column;

        
    }
}
