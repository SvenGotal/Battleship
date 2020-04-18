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
            m_rows = rows;
            m_cols = cols;
            m_fleet = f;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawCoordinateSystem(e.Graphics);
        }

        private void DrawCoordinateSystem(Graphics graphics)
        {
            using (Pen pen = new Pen(Color.Gray))
            {
                for (int i = 0; i <= m_rows; ++i)
                {
                    graphics.DrawLine(pen, 0, i * (ClientRectangle.Height-1) / m_rows,
                        ClientRectangle.Width, i * (ClientRectangle.Height-1) / m_rows);
                }
                for (int i = 0; i <= m_cols; ++i)
                {
                    graphics.DrawLine(pen, i * (ClientRectangle.Width - 1) / m_cols, 0,
                    i * (ClientRectangle.Width - 1) / m_cols, ClientRectangle.Height);
                }
            }
        }

        private Fleet m_fleet;
        private int m_rows;
        private int m_cols;
    }

}
