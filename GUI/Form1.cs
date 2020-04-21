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
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(numberOfLinesTextBox.Text, out numOfLines) && (numOfLines > 9 && numOfLines < 21))
            {
                errorMessage.Visible = false;
                drawPanel1.Lines = numOfLines;
                drawPanel1.Shipwright = new Shipwright(drawPanel1.Lines, drawPanel1.Lines);
                drawPanel1.Fleet = drawPanel1.Shipwright.CreateFleet(new int[] {5, 4, 4, 3, 3, 3, 2, 2, 2, 2});
                drawPanel1.Invalidate();
            }
            else
            {
                errorMessage.Visible = true;
            }
        }

        private int numOfLines;
    }
}