﻿using System;
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

            pictureBoxNazad.BackColor = System.Drawing.Color.Transparent;

            
        }

        // Prikazi
        private void buttonPrikazi_Click(object sender, EventArgs e)
        {         
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                Clan clan = new Clan(0, textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);
                bindingSourceClan.DataSource = clan.Ispis().Tables[0];
            }
            else
            {
                Clan clan = new Clan(int.Parse(textBoxID.Text), textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);
                bindingSourceClan.DataSource = clan.Ispis().Tables[0];
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
                    Clan clan = new Clan(0, textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);
                    clan.Kreiraj();

                    textBoxID.Text = "";
                    textBoxIme.Text = "";
                    textBoxPrezime.Text = "";
                    textBoxOIB.Text = "";
                }
                buttonPrikazi_Click(sender, e);
            }   
        }
             

        // Izbrisi
        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                MessageBox.Show("Unijeli ste nedovoljno podataka! \n Za brisanje je potrebno znati ID ili OIB!");
            }
            else if(String.IsNullOrEmpty(textBoxID.Text) == false)
            {
                Clan clan = new Clan(int.Parse(textBoxID.Text), textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);
                clan.Izbrisi();
                textBoxID.Text = "";
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxOIB.Text = "";
            }
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                Clan clan = new Clan(0, textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);
                clan.Izbrisi();
                textBoxID.Text = "";
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxOIB.Text = "";
            }

            buttonPrikazi_Click(sender, e);
        }

        // Izmjeni
        private void buttonIzmjeni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Molimo vas da unesete ID!");
            }
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                MessageBox.Show("Molimo vas da unesete neki podatak koji želite izmjeniti.");
            }
            else
            {
                Clan clan = new Clan(int.Parse(textBoxID.Text), textBoxIme.Text, textBoxPrezime.Text, textBoxOIB.Text);
                clan.Izmijeni();
                textBoxID.Text = "";
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxOIB.Text = "";
                buttonPrikazi_Click(sender, e);
            }
            
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

        private void dataGridViewClanovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = ((DataRowView)this.bindingSourceClan.Current).Row["ClanID"].ToString();
            textBoxIme.Text = ((DataRowView)this.bindingSourceClan.Current).Row["Ime"].ToString();
            textBoxPrezime.Text = ((DataRowView)this.bindingSourceClan.Current).Row["Prezime"].ToString();
            textBoxOIB.Text = ((DataRowView)this.bindingSourceClan.Current).Row["OIB"].ToString();
        }
    }
}
