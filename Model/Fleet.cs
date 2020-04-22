using System;
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

        public IEnumerable<Ship> Ships 
        {
            get { return ships; }
        }

        public Ship.HitResult Hit(Square square)
        {
            foreach (var ship in ships)
            {
                Ship.HitResult hit = ship.Hit(square);
                if (hit != Ship.HitResult.Missed)
                    return hit;
            }
            return Ship.HitResult.Missed;
        }

        private List<Ship> ships = new List<Ship>();
    }
}
