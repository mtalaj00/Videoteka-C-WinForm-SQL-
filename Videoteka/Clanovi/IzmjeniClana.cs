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
    class IzmjeniClana
    {
        public IzmjeniClana (int ID, String Ime, String Prezime, String OIB)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            // Kada mjenjamo samo Ime, prvo provjeravam postoji li clan s unesenim ID-om
            if (Ime.Length > 0 && Prezime.Length == 0 && OIB.Length == 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", ID);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Ime = @ime WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@ime", Ime);
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
            if (Ime.Length == 0 && Prezime.Length > 0 && OIB.Length == 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", ID);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Prezime = @prezime WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@prezime", Prezime);
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
            if (Ime.Length == 0 && Prezime.Length == 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", ID);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Prezime = @oib WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@oib", OIB);
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
            if (Ime.Length > 0 && Prezime.Length > 0 && OIB.Length == 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", ID);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Ime = @ime, Prezime =@prezime WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@ime", Ime);
                    cmd.Parameters.AddWithValue("@prezime", Prezime);
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
            if (Ime.Length > 0 && Prezime.Length == 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", ID);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Ime = @ime, OIB =@oib WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@ime", Ime);
                    cmd.Parameters.AddWithValue("@oib", OIB);
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
            if (Ime.Length == 0 && Prezime.Length > 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", ID);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Prezime =@prezime, OIB =@oib WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@prezime", Prezime);
                    cmd.Parameters.AddWithValue("@oib", OIB);
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
            if (Ime.Length > 0 && Prezime.Length > 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", ID);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);
                    dr.Close();

                    cmd = new SqlCommand("UPDATE Osoba SET Ime =@ime, Prezime =@prezime, OIB =@oib WHERE Osoba.OsobaID = @id", connection);
                    cmd.Parameters.AddWithValue("@ime", Ime);
                    cmd.Parameters.AddWithValue("@prezime", Prezime);
                    cmd.Parameters.AddWithValue("@oib", OIB);
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

    }
}
