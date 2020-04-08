using System.Collections.Generic;

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

        private List<Ship> ships = new List<Ship>();
    }
}
