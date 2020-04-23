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


namespace RazmjestajFlote
{
    public partial class Form1 : Form
    {
        Square s = new Square(10, 10);
        public Form1()
        {
            InitializeComponent(); 
            AddFields();
            AddColumnLabels();
            AddRowLabels();
        }
        void AddColumnLabels()
        {
            int unicode = 65;
            for (int i = 0; i < s.Column; i++)
            {               
                char character = (char)unicode;
                unicode++;

                Label column_label = new Label() {
                    Width = 40,
                    Height = 40,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(i * 40),
                    Left = 50 + i * 40,
                    Top = 10,
                    Text = character.ToString(),
                    Font= new Font(Font.FontFamily.Name, 16),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
            this.Controls.Add(column_label);
            }
        }
        void AddRowLabels()
        {
            for (int j = 0; j < s.Row; j++)
            {
                Label row_label = new Label()
                {
                    Width = 40, 
                    Height = 40, 
                    BorderStyle = BorderStyle.FixedSingle, 
                    Location = new Point(j*40),
                    Top = 50 + j * 40,
                    Left = 10,
                    Text = Convert.ToString(j + 1),
                    Font = new Font(Font.FontFamily.Name, 16),
                    TextAlign = ContentAlignment.MiddleCenter,  
                };
            this.Controls.Add(row_label);
            }
        }
        void AddFields()
        {
            for (int i = 0; i < s.Column; i++)
            {
                for (int j = 0; j < s.Row; j++)
                {
                    Button button = new Button();
                    button.Width = 40;
                    button.Height = 40;
                    button.Location = new Point(50+i * 40, 50+j * 40);
                    this.Controls.Add(button);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
