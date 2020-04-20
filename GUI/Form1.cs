using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace Vsite.Oom.Battleship.GUI
{
    public partial class BattleshipsGUI : Form
    {
        public BattleshipsGUI()
        {
            InitializeComponent();
            g = DrawPanel.CreateGraphics();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightBlue);
            DrawFleet();
        }


        private void DrawFleet()
        {
            myPen = new Pen(Color.Black, 2);
            myBrush = new SolidBrush(Color.DimGray);
            float x = 0f;
            float y = 0f;
            if (Int32.TryParse(numberOfLinesTextBox.Text, out numOfLines) && (numOfLines > 9 && numOfLines < 21))
            {
                distanceBetweenLines =  DrawPanel.Height / (float) numOfLines;
                errorMessage.Visible = false;
                for (int i = 0; i < numOfLines + 1; ++i)
                {
                    g.DrawLine(myPen, x, y, x, distanceBetweenLines * numOfLines);
                    x += distanceBetweenLines;
                }

                x = 0f;
                y = 0f;

                for (int i = 0; i < numOfLines + 1; ++i)
                {
                    g.DrawLine(myPen, x, y, distanceBetweenLines * numOfLines, y);
                    y += distanceBetweenLines;
                }

                DrawShips();

            }
            else
            {
                errorMessage.Visible = true;
            }
        }

        public void DrawShips()
        {
            Shipwright sw = new Shipwright(numOfLines,numOfLines);
            var fleet = sw.CreateFleet(new int[] {5, 4, 4, 3, 3, 3, 2, 2, 2, 2});

            foreach (var ship in fleet.Ships)
            {
                foreach (var square in ship.Squares)
                {
                    g.FillRectangle(myBrush,square.Column * distanceBetweenLines,square.Row * distanceBetweenLines,distanceBetweenLines,distanceBetweenLines);
                }
            }
        }

        private Pen myPen;
        private Brush myBrush;
        private Graphics g;
        private int numOfLines;
        private float distanceBetweenLines;
    }
}