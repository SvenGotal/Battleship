﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Fleet
    {
        
        public void AddShip(IEnumerable<Square> squares)
        {
            ships.Add(new Ship(squares));
        }
        
        public IEnumerable<Ship> Ships   //ovdi se "skriva" lista
        {
            get { return ships; }
        }

        private List<Ship> ships=new List<Ship>();
    }
}
