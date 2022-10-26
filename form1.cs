using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Remplir_grille(dataGridView1);
            Remplir_grille(dataGridView2);
        }

        private void Remplir_grille(DataGridView Pokemon)
        {
            //On met 5 colonnes
            Pokemon.ColumnCount = 5;
            Pokemon.Columns[0].Name = "NUM";
            Pokemon.Columns[1].Name = "NOM";
            Pokemon.Columns[2].Name = "ATTAQUE";
            Pokemon.Columns[3].Name = "DEFENSE";
            Pokemon.Columns[4].Name = "PVIE";
            //Création d'un tableau de 5 strings pour chaque ligne
            string[] row;
            row = new string[] { "1", "Bulbizarre", "49", "49", "45" };
            Pokemon.Rows.Add(row);
            row = new string[] { "2", "Herbizarre", "62", "63", "60" };
            Pokemon.Rows.Add(row);
            row = new string[] { "3", "Florizarre", "82", "83", "80" };
            Pokemon.Rows.Add(row);
            row = new string[] { "4", "Salamèche", "52", "43", "39" };
            Pokemon.Rows.Add(row);
            row = new string[] { "5", " Reptincel", "64", "58", "58" };
            Pokemon.Rows.Add(row);
            row = new string[] { "6", "Dracaufeu", "84", "78", "78" };
            Pokemon.Rows.Add(row);
            row = new string[] { "7", " Carapuce", "48", "65", "44" };
            Pokemon.Rows.Add(row);
            row = new string[] { "8", "Carabaffe", "63", "80", "59" };
            Pokemon.Rows.Add(row);
            row = new string[] { "9", "Tortank", "83", "100", "79" };
            Pokemon.Rows.Add(row);
            row = new string[] { "10", "Chenipan", "30", "35", "45" };
            Pokemon.Rows.Add(row);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int nbr_alea = rnd.Next(List_images.Images.Count);
            pictureBox2.Image = List_images.Images[nbr_alea];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = List_images.Images[dataGridView1.CurrentRow.Index];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
        }
    }
}
