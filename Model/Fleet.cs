using System.Collections.Generic;

namespace Vsite.Oom.Battleship.Model
{
    public class Fleet
    {
        private List<Ship> ships = new List<Ship>();

        public void AddShip(IEnumerable<Square> squares)
        {
            ships.Add(new Ship(squares));
        }

        public IEnumerable<Ship> Ships
        {
            get { return ships; }
        }

        public ShipHitResult Hit(Square square)
        {
            foreach (var ship in ships)
            {
                var hit = ship.Hit(square);
                if (hit != ShipHitResult.Missed)
                    return hit;
            }
            return ShipHitResult.Missed;
        }
    }
}
