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
    public partial class Clanovi : Form
    {
        public Clanovi()
        {
            InitializeComponent();                   
        }


        private void Clanovi_Load(object sender, EventArgs e)
        {
            labelID.BackColor = System.Drawing.Color.Transparent;
            labelIme.BackColor = System.Drawing.Color.Transparent;
            labelPrezime.BackColor = System.Drawing.Color.Transparent;
            labelOIB.BackColor = System.Drawing.Color.Transparent;
        }

        // Prikazi
        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                IspisClanova ispisClanova = new IspisClanova(0, textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text, this.dataGridViewClanovi);
            }
            else
            {
                IspisClanova ispisClanova = new IspisClanova(int.Parse(textBoxID.Text), textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text, this.dataGridViewClanovi);
            }
        }

        // Kreiraj
        private void buttonKreiraj_Click(object sender, EventArgs e)
        {
    
            // AKO JE JEDNO POLJE PRAZNO NECE IZVRSITI UNOS U BAZU PODATAKA (POLJE ID TREBA OSTATI PRAZNO JER SE U BAZI SAMO INKREMENTIRA)
            if(String.IsNullOrEmpty(textBoxIme.Text) || String.IsNullOrEmpty(textBoxPrezime.Text) || String.IsNullOrEmpty(textBoxOIB.Text))
            {
                MessageBox.Show("Molimo vas da popunite sva polja ! \n Polje ID nije obavezno.");
            }
            else
            {
                if (String.IsNullOrEmpty(textBoxID.Text) == false)
                {
                    MessageBox.Show("Molimo vas da polje 'ID' ostavite prazno !");
                }
                else
                {
                    KreirajNovogClana kreirajNovogClana = new KreirajNovogClana(textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);

                    textBoxID.Text = "";
                    textBoxIme.Text = "";
                    textBoxPrezime.Text = "";
                    textBoxOIB.Text = "";
                }                                       
            }   
        }

        private void dataGridViewClanovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = dataGridViewClanovi.Rows[e.RowIndex];

                textBoxID.Text = dataGridViewRow.Cells[0].Value.ToString();
                textBoxIme.Text = dataGridViewRow.Cells[1].Value.ToString();
                textBoxPrezime.Text = dataGridViewRow.Cells[2].Value.ToString();
                textBoxOIB.Text = dataGridViewRow.Cells[3].Value.ToString();
            }
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                MessageBox.Show("Unijeli ste nedovoljno podataka! \n Za brisanje je potrebno znati ID ili OIB!");
            }
            else if(String.IsNullOrEmpty(textBoxID.Text) == false)
            {
                IzbrisiClana izbrisiClana = new IzbrisiClana(int.Parse(textBoxID.Text), textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);
                textBoxID.Text = "";
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxOIB.Text = "";
            }
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                IzbrisiClana izbrisiClana = new IzbrisiClana(0, textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);
                textBoxID.Text = "";
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxOIB.Text = "";
            }

            buttonPrikazi_Click(sender, e);
        }
    }
}
