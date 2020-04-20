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
            DrawFleet(g);
        }


        private void DrawFleet(Graphics g)
        {
            myPen = new Pen(Color.Black, 2);
            myBrush = new SolidBrush(Color.Blue);
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
            }
            else
            {
                errorMessage.Visible = true;
            }
        }


        private Pen myPen;
        private Brush myBrush;
        private Graphics g;
        private int numOfLines;
        private float distanceBetweenLines;
    }
}
