using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;



namespace DisplayFleet
{
    public partial class FleetForm : Form
    {
        public FleetForm()
        {
            InitializeComponent();
            fleetGrid.GridSetup(Rows, Columns);

        }

        private void displayFleet(object sender, EventArgs e)
        {
            int[] shipSizes = new int[] { 5,4,4,3,3,3,2,2,2,2 };
            Shipwright b = new Shipwright(Rows, Columns);
            var flota = b.CreateFleet(shipSizes);
            fleetGrid.FleetSetup(flota);

        }
        int Rows = 10;
        int Columns = 10;

        private void quitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
