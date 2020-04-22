﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class shipwright
    {
        public shipwright(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        public fleet CreateFleet(IEnumerable<int> shipLengths) {
            for(int i = 0;i<3;++i)
            {
                fleet fl = placeShips(shipLengths);
                if (fl != null)
                {
                    return fl;
                }
            }
            throw new ArgumentOutOfRangeException();
        }

        private fleet placeShips(IEnumerable<int> shipLengths)
        {
            List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));
            Grid grid = new Grid(rows, columns);
            squareTerminator terminator = new squareTerminator(grid);
            fleet Fleet = new fleet();
            Random rand = new Random();
            while (lengths.Count() > 0)
            {
                var placements = grid.GetAvailablePlacements(lengths[0]);
                if (placements.Count() == 0) return null;
                lengths.RemoveAt(0);
                int index = rand.Next(0, placements.Count());
                Fleet.addShip(placements.ElementAt(index));
                var toElimiante = terminator.ToEliminate(placements.ElementAt(index));
                grid.eliminateSquares(toElimiante);
                }
            return Fleet;
        }
        private readonly int rows;
        private readonly int columns;
    }
}
