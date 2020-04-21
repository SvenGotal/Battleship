using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace Vsite.Oom.Battleship.GUI
{
    public partial class DrawPanel : Panel
    {
        public DrawPanel()
        {
            InitializeComponent();
            Lines = 10;
            myPen = new Pen(Color.Black, 2);
            myBrush = new SolidBrush(Color.DimGray);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGrid(e.Graphics);
            if(Fleet != null)
                DrawShips(e.Graphics);
        }


        private void DrawGrid(Graphics g)
        {
            float x = 0f;
            float y = 0f;

            distanceBetweenLines = Height / (float) Lines;

            for (int i = 0; i < Lines + 1; ++i)
            {
                g.DrawLine(myPen, x, y, x, distanceBetweenLines * Lines);
                x += distanceBetweenLines;
            }

            x = 0f;
            y = 0f;

            for (int i = 0; i < Lines + 1; ++i)
            {
                g.DrawLine(myPen, x, y, distanceBetweenLines * Lines, y);
                y += distanceBetweenLines;

            }
        }

        private void DrawShips(Graphics g)
        {

            foreach (var ship in Fleet.Ships)
            {
                foreach (var square in ship.Squares)
                {
                    g.FillRectangle(myBrush, square.Column * distanceBetweenLines,
                        square.Row * distanceBetweenLines, distanceBetweenLines, distanceBetweenLines);
                }
            }
        }


        private Pen myPen;
        private Brush myBrush;
        private float distanceBetweenLines;
        public Shipwright Shipwright { get; set; }
        public Fleet Fleet { get; set; }
        public int Lines { get; set; }




    }
}

