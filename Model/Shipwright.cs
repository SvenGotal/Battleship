﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Shipwright
    {
        public Shipwright(int rows, int columns) {
            this.rows = rows;
            this.columns = columns;
        }
        public Fleet CreateFleet(IEnumerable<int> shipLenght) {

           for(int i = 0; i<3;++i)
            {
                Fleet fleet = PlaceShips(shipLenght);
                if (fleet != null)
                    return fleet;
              
            }
           
            
            throw new ArgumentOutOfRangeException();
        }

        private Fleet PlaceShips(IEnumerable<int> shipLenght) {
            
            List<int> lenghts = new List<int>(shipLenght.OrderByDescending(x => x));

            Grid grid = new Grid(rows, columns);           
            SquareTerminator terminator = new SquareTerminator(grid);
            Fleet fleet = new Fleet();
            Random random = new Random();

            while (lenghts.Count > 0)
            {
                var placments = grid.GetAvailablePlacements(lenghts[0]);
                if (placments.Count() == 0)
                    return null;
                    
                lenghts.RemoveAt(0);

                int index = random.Next(0, placments.Count());

                fleet.AddShip(placments.ElementAt(index));
                // 6. eliminate squares form grid
                var toEliminate = terminator.ToEliminate(placments.ElementAt(index));
                grid.EliminateSquares(toEliminate);
                
            }
            return fleet;
        }

        private readonly int rows;
        private readonly int columns;
   
        private Random random = new Random();
        
    
    }
}
