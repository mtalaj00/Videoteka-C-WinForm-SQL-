using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    public partial class Filmovi : Form
    {
        public Filmovi()
        {
            InitializeComponent();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            IspisFilmova ispisFilmova = new IspisFilmova(textBoxID, textBoxNaziv, textBoxGodinaIzlaska, textBoxOcjena, dataGridViewFilmovi);            
        }

        private void Filmovi_Load(object sender, EventArgs e)
        {
            labelID.BackColor = System.Drawing.Color.Transparent;
            labelNaziv.BackColor = System.Drawing.Color.Transparent;
            labelGodinaIzlaska.BackColor = System.Drawing.Color.Transparent;           
            labelOcjena.BackColor = System.Drawing.Color.Transparent;

            pictureBoxNazad.BackColor = System.Drawing.Color.Transparent;
        }

        private void pictureBoxNazad_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void pictureBoxNazad_MouseHover(object sender, EventArgs e)
        {
            pictureBoxNazad.Cursor = Cursors.Hand;
        }

        private void pictureBoxNazad_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxNazad.Cursor = Cursors.Default;
        }

        private void buttonKreiraj_Click(object sender, EventArgs e)
        {

        }
    }
}
