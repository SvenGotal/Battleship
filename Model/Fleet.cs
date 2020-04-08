using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.oom.Battleship.Model
{
public class Fleet
    {   
        public void AddShip(IEnumerable<Square> squares)
        {
            ships.Add(new Ship(squares));

        }

        public IEnumerable<Ship> Ships
        {
            get { return Ships; }
        }
        private List<Ship>ships=new List<Ship>();
    }
}
