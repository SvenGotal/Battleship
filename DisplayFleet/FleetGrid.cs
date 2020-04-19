using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Oom.Battleship.Model;
using System.Drawing;
using System.Windows.Forms;

namespace DisplayFleet
{
    public partial class FleetGrid : Control
    {
        public FleetGrid()
        {
            InitializeComponent();
            ResizeRedraw = true;

        }

        public FleetGrid(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void GridSetup(int Rows, int Columns)
        {
            if (this.Columns == Columns && this.Rows == Rows)
                return;
            this.Columns = Columns;
            this.Rows = Rows;
            Invalidate();
        }

        public void FleetSetup(Fleet fleet)
        {
            this.fleet = fleet;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            int Width = FieldWidth * Columns + 1;
            int Height = FieldHeight * Rows + 1;
            pe.Graphics.FillRectangle(SystemBrushes.Window, 0, 0, Width, Height);
            HorizontalLine(pe);
            VerticalLine(pe);
            if (fleet != null)
                foreach (Ship ship in fleet.Ships)
                    foreach (Square field in ship.Squares)
                        DrawFleet(pe, field);
                
            base.OnPaint(pe);
        }



        private void HorizontalLine(PaintEventArgs pe)
        {
            int x1 = 0;
            int x2 = FieldWidth * Columns;
            int y = 0;
            for (int r = 0; r <= Rows; ++r)
            {
                pe.Graphics.DrawLine(gridLiner, x1, y, x2, y);
                y += FieldHeight;
            }
        }

        private void VerticalLine(PaintEventArgs pe)
        {
            int x = 0;
            int y1 = 0;
            int y2 = FieldHeight * Rows;
            for (int s = 0; s <= Columns; ++s)
            {
                pe.Graphics.DrawLine(gridLiner, x, y1, x, y2);
                x += FieldWidth;
            }
        }


        private void DrawFleet(PaintEventArgs pe, Square square)
        {
            int Column = square.Column;
            int Row = square.Row;
            int y = Column * FieldHeight;
            int x = Row * FieldWidth;
            pe.Graphics.FillRectangle(shipColors, x, y, FieldWidth, FieldHeight);
            pe.Graphics.DrawRectangle(gridLiner, x, y, FieldWidth, FieldHeight);
        }
       

        


        private int Rows = 10;
        private int Columns = 10;
        private Fleet fleet;
        private int FieldWidth { get { return (ClientRectangle.Width - 1) / Rows; } }
        private int FieldHeight{ get { return (ClientRectangle.Height - 1) / Columns; } }

        private Pen gridLiner = new Pen(SystemColors.MenuHighlight);
        public Brush shipColors = new SolidBrush(Color.Black);
    }
}

