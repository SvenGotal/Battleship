using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class grid
    {
        public grid(int rw, int cl)
        {
            Rw = rw;
            Cl = cl;
        }
        public readonly int Rw;
        public readonly int Cl;
        public IEnumerable<IEnumerable<square>> GetAvaliablePlacements(int len)
        {
            throw new NotImplementedException();
        }
    }
}
