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

namespace FleetView
{
	public partial class FleetForm : Form
	{
		public FleetForm()
		{
			InitializeComponent();
		}
		private void buttonAgreesOnClick(object sender, EventArgs e)
		{
			int[] shipSize = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };
			Shipwright b = new Shipwright(rows, cols);
			var fleet = b.CreateFleet(shipSize);
			
		}

		int rows = 10;
		int cols = 10;
	}
}
