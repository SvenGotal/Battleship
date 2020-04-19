using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using Vsite.Oom.Battleship.Model;
using System.Windows.Forms;

namespace Vsite.Oom.Battleship.Gui
{
    class GuiPanel : System.Windows.Forms.Panel
    {
        public GuiPanel()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        public void SetSize(int rows, int cols, Fleet f)
        {
            m_rows += rows;
            m_cols += cols;
            m_fleet = f;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGrid(e.Graphics);
            FillShipSquares(e.Graphics);
        }

        private void DrawGrid(Graphics graphics)
        {
            using (Pen pen = new Pen(Color.Gray))
            {
                m_cell_height = (ClientRectangle.Height - 1) / (float)m_rows;
                m_cell_width = (ClientRectangle.Width - 1) / (float)m_cols;

                for (int i = 0; i <= m_rows; ++i)
                {
                    using (Font f = new Font("Times New Roman", 12, FontStyle.Regular))
                        if (i != 0)
                            graphics.DrawString(Convert.ToChar(64 + i).ToString(), f, Brushes.Black, 0, i * m_cell_height);

                    if (i != 0)
                        graphics.DrawLine(pen, -1 + m_cell_height,
                             i * m_cell_height, ClientRectangle.Width, i * m_cell_height);
                }

                for (int i = 0; i <= m_cols; ++i)
                {
                    using (Font f = new Font("Times New Roman", 12, FontStyle.Regular))
                        if (i != 0)
                            graphics.DrawString((i).ToString(), f, Brushes.Black, i * m_cell_width, 0);

                    if (i != 0)
                        graphics.DrawLine(pen, i * m_cell_width, -1 + m_cell_width,
                            i * m_cell_width, ClientRectangle.Height);
                }
            }
        }

        private void FillShipSquares(Graphics graphics)
        {

            foreach (Ship ship in m_fleet.Ships)
            {
                foreach (Square field in ship.Squares)
                {
                    using (SolidBrush pen = new SolidBrush(Color.Blue)) 
                    {
                        graphics.FillRectangle(pen, field.Column * m_cell_width + m_cell_width, field.Row * m_cell_height + m_cell_height, m_cell_width, m_cell_height);
                    }
                }
            }
            
        }

        private Fleet m_fleet;
        private int m_rows=1;
        private int m_cols=1;
        private float m_cell_height;
        private float m_cell_width;
    }

}
