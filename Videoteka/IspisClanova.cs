using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    class IspisClanova
    {
        Osoba osoba = new Osoba();


        public IspisClanova(int id, String ime, String prezime, String oib, DataGridView dataGridView)
        {
            osoba.setID(id);
            osoba.setIme(ime);
            osoba.setPrezime(prezime);
            osoba.setOIB(oib);


            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
                connection.Open();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();


                //  ISPIS SVIH CLANOVA AKO NEMA UNESENIH PODATAKA
                if (osoba.getID() == 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length == 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID", connection);
                }

                //  ISPIS PREMA ID-u
                else if (osoba.getID() > 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length == 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);

                    cmd.Parameters.AddWithValue("@id", osoba.getID());
                }

                //  ISPIS PREMA IMENU
                else if (osoba.getID() == 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length == 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime", connection);

                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                }

                //  ISPIS PREMA PREZIMENU
                else if (osoba.getID() == 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length == 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Prezime = @prezime", connection);

                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                }

                //  ISPIS PREMA OIB-u
                else if (osoba.getID() == 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);

                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                }

                //  ISPIS PREMA IMENU I PREZIMENU
                else if (osoba.getID() == 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length == 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.Prezime = @prezime", connection);

                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                }

                //  ISPIS PREMA IMENU I OIB-u
                else if (osoba.getID() == 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.OIB = @oib", connection);

                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                }

                //  ISPIS PREMA PREZIMENU I OIB-u
                else if (osoba.getID() == 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);

                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                }

                //  ISPIS PREMA ID-u I IMENU
                else if (osoba.getID() > 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length == 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime", connection);

                    cmd.Parameters.AddWithValue("@id", osoba.getID());
                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                }

                //  ISPIS PREMA ID-u I PREZIMENU
                else if (osoba.getID() > 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length == 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Prezime = @prezime", connection);

                    cmd.Parameters.AddWithValue("@id", osoba.getID());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                }

                //  ISPIS PREMA ID-u I OIB-u
                else if (osoba.getID() > 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.OIB = @oib", connection);

                    cmd.Parameters.AddWithValue("@id", osoba.getID());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                }
                //  ISPIS PREMA ID-u, IMENU I PREZIMENU
                else if (osoba.getID() > 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length == 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.Prezime = @prezime", connection);

                    cmd.Parameters.AddWithValue("@id", osoba.getID());
                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                }

                //  ISPIS PREMA ID-u, IMENU I OIB-u
                else if (osoba.getID() > 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.OIB = @oib", connection);

                    cmd.Parameters.AddWithValue("@id", osoba.getID());
                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                }

                //  ISPIS PREMA ID-u, PREZIMENU I OIB-u
                else if (osoba.getID() > 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);

                    cmd.Parameters.AddWithValue("@id", osoba.getID());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                }

                //  ISPIS PREMA IMENU, PREZIMENU I OIB-u
                else if (osoba.getID() == 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);

                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                }

                //  ISPIS PREMA ID-u, IMENU, PREZIMENU I OIB-u
                else if (osoba.getID() > 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);

                    cmd.Parameters.AddWithValue("@id", osoba.getID());
                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                }


                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                // moran napraviti jos ispis na - dataGridViewClanovi.DataSource = table;
                dataGridView.DataSource = table;
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }


    }
}
