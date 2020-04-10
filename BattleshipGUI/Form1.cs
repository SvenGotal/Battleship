using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using modelNmspc = Vsite.Oom.Battleship.Model;

namespace BattleshipGUI
{   
    public partial class Form1 : Form
    {
        private modelNmspc.Grid gr = new modelNmspc.Grid(10, 10);
        private modelNmspc.fleet fl = new modelNmspc.fleet();
        public Form1()
        {
            InitializeComponent();
        }
        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            CreateGrid();
            DrawGrid();
         }
        private bool CheckIfSquareIsInFleet(int row, int column)
        {
            var shipsList = fl.Ships;
            using (var sequenceEnum1 = shipsList.GetEnumerator())
            {
                while (sequenceEnum1.MoveNext())
                {
                    var ship = sequenceEnum1.Current;
                    var squares = ship.squares;
                    using (var sequenceEnum2 = squares.GetEnumerator())
                    {
                        while (sequenceEnum2.MoveNext())
                        {
                            var square = sequenceEnum2.Current;
                            if(square.column == column && square.row == row) {
                                return true; }
                        }
                    }
                }
            }
            return false;
        }
        private void PrintOutFleetPositions()
        {
            var shipsList = fl.Ships;
            using (var sequenceEnum1 = shipsList.GetEnumerator())
            {
                while (sequenceEnum1.MoveNext())                                               //debugging purpose only
                {
                    var ship = sequenceEnum1.Current;
                    var squares = ship.squares;
                    using (var sequenceEnum2 = squares.GetEnumerator())
                    {
                        while (sequenceEnum2.MoveNext())
                        {
                            var square = sequenceEnum2.Current;
                            Console.WriteLine("col = " + square.column + " row=" + square.row);

                        }
                        Console.WriteLine("ship over---!");
                    }
                }
            }
        }
        private void DrawGrid()
        {  
            Graphics graphobject = grid.CreateGraphics();                      

            Brush blueBrush = new SolidBrush(Color.Blue);
            Pen bluePen = new Pen(blueBrush, 8);
            Brush grayBrush = new SolidBrush(Color.Gray);
            Pen grayPen = new Pen(grayBrush, 8);
            int column = 0;
            int row = 0;
            PrintOutFleetPositions();                                                //debugging purpose only
            for (int i = 0; i != 500; i += 50)
            {
                for (int j = 0; j != 500; j += 50)
                {
                    if (CheckIfSquareIsInFleet(column,row))
                    {
                        graphobject.FillRectangle(blueBrush, j, i, 49, 49);           //crta plava ili siva polja ovisno da li se nalaze u fleet-u
                    }
                    else
                    {
                        graphobject.FillRectangle(grayBrush, j, i, 49, 49);
                    }
                    ++column;
                }
                column = 0;
                ++row;
            }
                      
          
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            CreateGrid();
            DrawGrid();
        }

        private void CreateGrid()
        {
            int trigger = 1;
            int shipLength = 2;
            var availableSquares = gr.GetAvailablePlacements(shipLength);       //dohvaćanje mogućih pozicija na gridu za ship duljine 2
            ChooseRandomShipPositions_AddToFleet_Eliminate(availableSquares);  //uzima random poziciju od mogućih pozicija, dodaje u flotu, te eliminira iz grida
            for (int i = 0; i < 9; ++i)
            {
                switch (trigger)
                {
                    case 4:
                        ++shipLength;
                        break;                                        //petlja radi isto što i prethodna dva komentara, 
                    case 7:                                          //samo što za ship zadane duljine ponavlja koliko je potrebno ovisno o pravilima igre
                        ++shipLength;                               //npr. ship duljine 2 treba postaviti 4 puta
                        break;
                    case 9:
                        ++shipLength;
                        break;
                    case 10:
                        ++shipLength;
                        break;

                }
                availableSquares = gr.GetAvailablePlacements(shipLength);
                ChooseRandomShipPositions_AddToFleet_Eliminate(availableSquares);
                ++trigger;
            }
        }

        private void ChooseRandomShipPositions_AddToFleet_Eliminate(IEnumerable<IEnumerable<modelNmspc.Square>> availablePositions)
        {
            Random random = new Random();
            int result = availablePositions.Count();
            int randomPosition = random.Next(0, result);
            int counter=0;
            List<modelNmspc.Square> squaresToAddAndElim=null;
            IEnumerable<modelNmspc.Square> ship = null;
            using (var sequenceEnum = availablePositions.GetEnumerator()) 
            {
                while (sequenceEnum.MoveNext())                             //prolazak kroz validne pozicije,
                {                                                          // te random odabir jedne od njih
                    if (counter == randomPosition-1)
                    {
                        ship = sequenceEnum.Current;
                    }
                    ++counter;
                }
            }
            int initCounter = 0;
            using (var sequenceEnum = ship.GetEnumerator())
            {
                while (sequenceEnum.MoveNext())
                {
                    if (initCounter == 0)                                  //prolazak kroz svaki square  u izabranoj validnoj poziciji
                    {
                        var square = sequenceEnum.Current;
                        squaresToAddAndElim = new List<modelNmspc.Square> { new modelNmspc.Square(square.row, square.column)};
                        ++initCounter;
                    }
                    else
                    {
                        var square = sequenceEnum.Current;
                        squaresToAddAndElim.Add(square);
                    }
                    
                }
            }
            //using (var sequenceEnum = squaresToAddAndElim.GetEnumerator())
            //{
            //    while (sequenceEnum.MoveNext())
            //    {                                                                         //used for debuggin only
             
            //            var square = sequenceEnum.Current;
            //        var c = square.column;
            //        var r = square.row;
            //    }
            //}
            fl.addShip(squaresToAddAndElim);                                           //dodaje u flotu sve shipove koji su random odabrani
            gr.eliminateSquares(squaresToAddAndElim);                                  //eliminira iz grida sve square-ove odabranih shipova
                  }
    }
}
