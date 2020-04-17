using System;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace FleetView
{
	public partial class FleetForm : Form
	{
		public FleetForm()
		{
			InitializeComponent();
			gridForFleet.SetupGrid(cols, rows);
		}
		private void buttonAgreesOnClick(object sender, EventArgs e)
		{
			int[] shipSize = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };
			Shipwright ship = new Shipwright(rows, cols);
			var fleet = ship.CreateFleet(shipSize);
			gridForFleet.FleetSetup(fleet);
		}
		private void buttonQuitOnClick(object sender, EventArgs e)
		{
			Close();
		}

		int rows = 10;
		int cols = 10;
	}
}
