using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.Oom.Battleship.Model
{
    public class Ship
    {
        public Ship(IEnumerable<Square> squares) {


            this.squares = squares;
        }






        public readonly IEnumerable<Square> squares;














    }
}
