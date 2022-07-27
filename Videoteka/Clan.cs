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
    class Clan
    {

        Osoba osoba = new Osoba();

        public Clan(int id, String ime, String prezime, String oib)
        {
            osoba.setID(id);
            osoba.setIme(ime);
            osoba.setPrezime(prezime);
            osoba.setOIB(oib);
        }

        public BindingSource Ispis()
        {
            BindingSource bindingSource = new BindingSource();

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
                connection.Open();

                //DataTable table = new DataTable();
                DataSet dataSet = new DataSet();
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
                adapter.Fill(dataSet);

                bindingSource.DataSource = dataSet.Tables[0];

                connection.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }


            return bindingSource;

        }


        public void Izbrisi()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            // Ukoliko je zadan samo ID, provjeravam postoji li clan s tim ID-om, ako postoji brisemo ga
            if (osoba.getID() > 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length == 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", osoba.getID());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Član obrisan.");
                    }

                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }
            }

            // Ukoliko je zadan ID i Ime, prvo provjeravam postoji li clan s tim ID-om i s tim Imenom, ako postoji brisemo ga
            else if (osoba.getID() > 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length == 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());
                cmd.Parameters.AddWithValue("@ime", osoba.getIme());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", osoba.getID());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID i Prezime, prvo provjeravam postoji li clan s tim ID-om i s tim Prezimenom, ako postoji brisemo ga
            else if (osoba.getID() > 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length == 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Prezime = @prezime", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());
                cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", osoba.getID());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID i OIB, prvo provjeravam postoji li clan s tim ID-om i s tim OIB-om, ako postoji brisemo ga
            else if (osoba.getID() > 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", osoba.getID());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID, Ime i Prezime, prvo provjeravam postoji li clan s tim ID-om i s tim OIB-om, ako postoji brisemo ga
            else if (osoba.getID() > 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length == 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.Prezime = @prezime", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());
                cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", osoba.getID());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID, Ime i OIB, prvo provjeravam postoji li clan s tim ID-om i s tim OIB-om, ako postoji brisemo ga
            else if (osoba.getID() > 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());
                cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", osoba.getID());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID, Prezime i OIB, prvo provjeravam postoji li clan s tim ID-om i s tim OIB-om, ako postoji brisemo ga
            else if (osoba.getID() > 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());
                cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", osoba.getID());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }
            // Ukoliko je zadan samo OIB, prvo provjeravam postoji li clan s tim OIB-om, ako postoji brisemo ga
            else if (osoba.getID() == 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("SELECT Clan.ClanID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                        cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();

                        int id = dr.GetInt32(0);

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                        dr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadano Ime i OIB, prvo provjeravam postoji li clan s tim Imenom i OIB-om, ako postoji brisemo ga
            else if (osoba.getID() == 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("SELECT Clan.ClanID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                        cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();

                        int id = dr.GetInt32(0);

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                        dr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadano Prezime i OIB, prvo provjeravam postoji li clan s tim Prezimenom i OIB-om, ako postoji brisemo ga
            else if (osoba.getID() == 0 && osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("SELECT Clan.ClanID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                        cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();

                        int id = dr.GetInt32(0);

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                        dr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadano Ime, Prezime i OIB, prvo provjeravam postoji li clan s tim Imenom, Prezimenom i OIB-om, ako postoji brisemo ga
            else if (osoba.getID() == 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("SELECT Clan.ClanID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                        cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();

                        int id = dr.GetInt32(0);

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                        dr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko su zadani svi podaci, prvo provjeravam postoji li clan s tim podacima, ako postoji brisemo ga
            else if (osoba.getID() > 0 && osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());
                cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovog člana ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", osoba.getID());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Član obrisan.");
                    }
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            connection.Close();
        }


        public void Izmijeni()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            // Kada mjenjamo samo Ime, prvo provjeravam postoji li clan s unesenim ID-om
            if (osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length == 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", osoba.getID());

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Ime = @ime WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno izmjenjeno.");

                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }
            }

            // Kada mjenjamo samo Prezime, prvo provjeravam postoji li clan s unesenim ID-om
            else if (osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length == 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", osoba.getID());

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Prezime = @prezime WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno izmjenjeno.");

                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }
            }

            // Kada mjenjamo samo OIB, prvo provjeravam postoji li clan s unesenim ID-om
            else if (osoba.getIme().Length == 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", osoba.getID());

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Prezime = @oib WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno izmjenjeno.");

                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }
            }

            // Kada mjenjamo Ime i Prezime, prvo provjeravam postoji li clan s unesenim ID-om
            else if (osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length == 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", osoba.getID());

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Ime = @ime, Prezime =@prezime WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno izmjenjeno.");

                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }
            }

            // Kada mjenjamo Ime i OIB, prvo provjeravam postoji li clan s unesenim ID-om
            else if (osoba.getIme().Length > 0 && osoba.getPrezime().Length == 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", osoba.getID());

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Ime = @ime, OIB =@oib WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno izmjenjeno.");

                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }
            }

            // Kada mjenjamo Prezime i OIB, prvo provjeravam postoji li clan s unesenim ID-om
            else if (osoba.getIme().Length == 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", osoba.getID());

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Prezime =@prezime, OIB =@oib WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno izmjenjeno.");

                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }
            }

            // Kada mjenjamo sve podatke, prvo provjeravam postoji li clan s unesenim ID-om
            else if (osoba.getIme().Length > 0 && osoba.getPrezime().Length > 0 && osoba.getOIB().Length > 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", osoba.getID());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", osoba.getID());

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Ime =@ime, Prezime =@prezime, OIB =@oib WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno izmjenjeno.");

                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }
            }



        }


        public void Kreiraj()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
                connection.Open();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                // Provjeravam postoji li osoba s tim podacima
                SqlCommand cmd = new SqlCommand("SELECT * FROM Osoba WHERE Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Osoba s tim podacima već postoji.");
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Osoba VALUES (@ime, @prezime, @oib)", connection);

                    cmd.Parameters.AddWithValue("@ime", osoba.getIme());
                    cmd.Parameters.AddWithValue("@prezime", osoba.getPrezime());
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba WHERE Osoba.OIB = @oib", connection);
                    cmd.Parameters.AddWithValue("@oib", osoba.getOIB());

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int d = dr.GetInt32(0);

                    dr.Close();

                    cmd = new SqlCommand("INSERT INTO Clan VALUES (@idOsoba, 1)", connection);
                    cmd.Parameters.AddWithValue("@idOsoba", d);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno ste dodali novog člana.");
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

    }
}
