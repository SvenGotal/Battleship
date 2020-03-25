﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Square //stavili smo public da možemo testirati iz drugog modula
    {
        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }
        public readonly int Row;
        public readonly int Column;
    }
}
