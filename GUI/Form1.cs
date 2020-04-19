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

namespace GUI
{
	public partial class Form1 : Form
	{
		Rectangle[,] allFields;
		Graphics graphics;

		public Form1()
		{
			InitializeComponent();
			allFields = new Rectangle[10, 10];
			graphics = GameBoard.CreateGraphics();
		}

		private void CreateFleetButton_Click(object sender, EventArgs e)
		{
			RefreshMap();

			List<int> ships = new List<int>
			{
				2,2,2,2,3,3,3,4,4,5
			};
			Fleet fleet = new Fleet();
			Shipwright shipwright = new Shipwright(10, 10);
			fleet = shipwright.CreateFleet(ships);

			Size fillSize = new Size(39, 39);

			for (int r = 0; r < 10; r++)
			{
				for (int c = 0; c < 10; c++)
				{
					foreach (var ship in fleet.Ships)
					{
						if (ship.Squares.Contains(new Square(r, c)))
						{
							Rectangle fillRectangle = allFields[r, c];
							fillRectangle.Size = fillSize;
							fillRectangle.X += 1;
							fillRectangle.Y += 1;
							graphics.FillRectangle(new SolidBrush(Color.DarkBlue), fillRectangle);

						}
					}
				}

			}
					

		}

		private void DrawSquares(object sender, PaintEventArgs e)
		{
				Pen pen = new Pen(Color.DarkGray, 1);
				Size squareSize = new Size(40, 40);
				Size fillSize = squareSize;
				fillSize.Width -= 1;
				fillSize.Height -= 1;

				for (int r = 0; r < 10; r++)
				{
					for (int c = 0; c < 10; c++)
					{
						allFields[r, c] = new Rectangle(new Point((r * 40) + 10, (c * 40) + 5), squareSize);
						graphics.DrawRectangle(pen, allFields[r, c]);

						Rectangle fillRectangle = new Rectangle(new Point((r * 40) + 10 + 1, (c * 40) + 5 + 1), fillSize);
						graphics.FillRectangle(new SolidBrush(Color.White), fillRectangle);
					}
				}

				pen.Dispose();
		}

		private void RefreshMap()
		{
			Size fillSize = new Size(39, 39);

			for (int r = 0; r < 10; r++)
			{
				for (int c = 0; c < 10; c++)
				{
					Rectangle fillRectangle = allFields[r, c];
					fillRectangle.Size = fillSize;
					fillRectangle.X += 1;
					fillRectangle.Y += 1;
					graphics.FillRectangle(new SolidBrush(Color.White), fillRectangle);
				}
			}
		}
	}
}
