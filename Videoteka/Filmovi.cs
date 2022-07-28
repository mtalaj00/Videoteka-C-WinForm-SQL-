using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        // PRIKAZI FILM
        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            IspisFilmova ispisFilmova = new IspisFilmova();

            bindingSourceFilm.DataSource = ispisFilmova.getDaTaSet(textBoxID, textBoxNaziv, textBoxGodinaIzlaska, textBoxOcjena).Tables[0];
                              
        }

        // KREIRAJ FILM
        private void buttonKreiraj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                KreirajFilm kreirajFilm = new KreirajFilm(textBoxNaziv, textBoxGodinaIzlaska, textBoxOcjena);

                textBoxID.Text = "";
                textBoxNaziv.Text = "";
                textBoxGodinaIzlaska.Text = "";
                textBoxOcjena.Text = "";

                buttonPrikazi_Click(sender,e);
            }
            else
            {
                MessageBox.Show("U polje ID nije potrebno unijeti podatke.");
            }
            
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
        
        // IZBRISI FILM
        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            IzbrisiFilm izbrisiFilm = new IzbrisiFilm(textBoxID, textBoxNaziv, textBoxGodinaIzlaska, textBoxOcjena);
                        
            textBoxID.Text = "";
            textBoxNaziv.Text = "";
            textBoxGodinaIzlaska.Text = "";
            textBoxOcjena.Text = "";

            buttonPrikazi_Click(sender, e);
        }

        // IZMIJENI FILM
        private void buttonIzmjeni_Click(object sender, EventArgs e)
        {
            AzurirajFilm azurirajFilm = new AzurirajFilm(textBoxID, textBoxNaziv, textBoxGodinaIzlaska, textBoxOcjena);

            textBoxID.Text = "";
            textBoxNaziv.Text = "";
            textBoxGodinaIzlaska.Text = "";
            textBoxOcjena.Text = "";

            buttonPrikazi_Click(sender, e);
        }

        private void dataGridViewFilmovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = ((DataRowView)this.bindingSourceFilm.Current).Row["FilmID"].ToString();
            textBoxNaziv.Text = ((DataRowView)this.bindingSourceFilm.Current).Row["Naziv"].ToString();
            textBoxGodinaIzlaska.Text = ((DataRowView)this.bindingSourceFilm.Current).Row["Godina_Izlaska"].ToString();
            textBoxOcjena.Text = ((DataRowView)this.bindingSourceFilm.Current).Row["Ocjena"].ToString();
        }
    }
}
