﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class ship
    {
        public ship(IEnumerable<Square> squares) {
            this.squares = squares;
        }
        public readonly IEnumerable<Square> squares;

    }
}
