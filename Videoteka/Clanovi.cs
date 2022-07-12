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
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            //  ISPIS SVIH CLANOVA AKO NEMA UNESENIH PODATAKA
            if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID", connection);                 
            }

            //  ISPIS PREMA ID-u
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
            }

            //  ISPIS PREMA IMENU
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxIme.Text) == false && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime", connection);

                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
            }

            //  ISPIS PREMA PREZIMENU
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) == false && String.IsNullOrEmpty(textBoxOIB.Text))
            {               
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Prezime = @prezime", connection);

                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
            }

            //  ISPIS PREMA OIB-u
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);

                cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);
            }

            //  ISPIS PREMA IMENU I PREZIMENU
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxIme.Text) == false && String.IsNullOrEmpty(textBoxPrezime.Text) == false && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.Prezime = @prezime", connection);

                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
            }

            //  ISPIS PREMA IMENU I OIB-u
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxIme.Text) == false && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);

                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);
            }

            //  ISPIS PREMA PREZIMENU I OIB-u
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) == false && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.OIB = @oib", connection);

                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);
            }

            //  ISPIS PREMA ID-u I IMENU
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) == false && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime", connection);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);               
            }

            //  ISPIS PREMA ID-u I PREZIMENU
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) == false && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Prezime = @prezime", connection);

                cmd.Parameters.AddWithValue("id", int.Parse(textBoxID.Text));
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
            }

            //  ISPIS PREMA ID-u I OIB-u
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.OIB = @oib", connection);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);
            }

            //  ISPIS PREMA ID-u, IMENU I PREZIMENU
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) == false && String.IsNullOrEmpty(textBoxPrezime.Text) == false && String.IsNullOrEmpty(textBoxOIB.Text))
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.Prezime = @prezime", connection);

                cmd.Parameters.AddWithValue("id", int.Parse(textBoxID.Text));
                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
            }

            //  ISPIS PREMA ID-u, IMENU I OIB-u
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) == false && String.IsNullOrEmpty(textBoxPrezime.Text) && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.OIB = @oib", connection);

                cmd.Parameters.AddWithValue("id", int.Parse(textBoxID.Text));
                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);
            }

            //  ISPIS PREMA ID-u, PREZIMENU I OIB-u
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) && String.IsNullOrEmpty(textBoxPrezime.Text) == false && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);

                cmd.Parameters.AddWithValue("id", int.Parse(textBoxID.Text));
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);
            }

            //  ISPIS PREMA IMENU, PREZIMENU I OIB-u
            else if (String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxIme.Text) == false && String.IsNullOrEmpty(textBoxPrezime.Text) == false && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);

                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);
            }

            //  ISPIS PREMA ID-u, IMENU, PREZIMENU I OIB-u
            else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxIme.Text) == false && String.IsNullOrEmpty(textBoxPrezime.Text) == false && String.IsNullOrEmpty(textBoxOIB.Text) == false)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);

                cmd.Parameters.AddWithValue("id", int.Parse(textBoxID.Text));
                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);
            }

            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }



        // Kreiraj
        private void buttonClanovi_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
            connection.Open();
                       

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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Osoba VALUES (@ime, @prezime, @oib)", connection);

                    cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                    cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                    cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba WHERE Osoba.OIB = @oib", connection);
                    cmd.Parameters.AddWithValue("@oib", textBoxOIB.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int d = dr.GetInt32(0);

                    dr.Close();

                    cmd = new SqlCommand("INSERT INTO Clan VALUES (@idOsoba, 1)", connection);
                    cmd.Parameters.AddWithValue("@idOsoba", d);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno ste dodali novog člana.");


                    textBoxID.Text = "";
                    textBoxIme.Text = "";
                    textBoxPrezime.Text = "";
                    textBoxOIB.Text = "";
                }                   
                    
            }
            connection.Close();



        }

    }
}
