using Microsoft.Build.BuildEngine;
using Model;
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

namespace ArrangeFleetGUI
{
    public partial class Battleship : Form
    {
        public Battleship()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

       

        private void button101_Click(object sender, EventArgs e)
        {
            

            String buttonname;
            List<Button> listofbuttons = this.Controls.OfType<Button>()
                 .Concat(this.panel1.Controls.OfType<Button>())
                 .ToList();
            List<Button> buttonsclicked = new List<Button>();
            Shipwright shipwright = new Shipwright(10, 10);
            var fleet = shipwright.CreateFleet(new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 });
            var flag = 0; 
           
            var listofships = fleet.Ships.ToList();
            var rowlist = new List<int>();
            var collist = new List<int>();

            foreach (var a in listofships)
            {
                var squares = a.Squares;
                foreach (var b in squares)
                {
                    var r = b.Row;
                    var c = b.Column;

                    for (int i = 0; i < 10; ++i)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (i == c && r == j)
                            {
                                buttonname = "row" + i + "col" + j;
                                foreach (var but in listofbuttons)
                                {
                                    if (but.Name == buttonname)
                                    {
                                        but.BackColor = SystemColors.ControlDarkDark;
                                 
                                        
                                    }
                                }
                            }
                        }
                    }

                }
                flag = 1;
            }


            if (flag == 1)
            {
                button101.Enabled = false;
               
                DialogResult dialogResult = MessageBox.Show("Do you want to arrange fleet again?", "No", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                
                    Battleship form = new Battleship();
                    form.Show();
                }
            
               
                
            }   

        }
    }
}

