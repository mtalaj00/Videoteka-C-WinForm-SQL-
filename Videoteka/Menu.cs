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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonClanovi_Click(object sender, EventArgs e)
        {
            Clanovi clanovi = new Clanovi();
            this.Hide();
            clanovi.Show();
        }

        private void buttonFilmovi_Click(object sender, EventArgs e)
        {
            Filmovi filmovi = new Filmovi();
            this.Hide();
            filmovi.Show();
        }
    }
}
