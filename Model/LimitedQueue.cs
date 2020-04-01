using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.BattleShip.Model
{
    public class LimitedQueue<T> : Queue<T>
    {
        public LimitedQueue(int length)
        {
            this.length = length;
        }

        public new void Enqueue(T item)
        {
            base.Enqueue(item);
            while (this.Count > length)
            {
                base.Dequeue();
            }
        }


        private readonly int length;
    }
}
