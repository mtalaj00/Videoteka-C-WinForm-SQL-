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
    class IzbrisiClana
    {
        public IzbrisiClana(int ID, String Ime, String Prezime, String OIB)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            // Ukoliko je zadan samo ID, provjeravam postoji li clan s tim ID-om, ako postoji brisemo ga
            if (ID > 0 && Ime.Length == 0 && Prezime.Length == 0 && OIB.Length == 0)
            {
                cmd = new SqlCommand("SELECT * FROM Clan WHERE Clan.ClanID = @id", connection);
                cmd.Parameters.AddWithValue("@id", ID);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Član obrisan.");
                }
                else
                {
                    MessageBox.Show("Član s tim ID-om ne postoji!");
                }              
            }

            // Ukoliko je zadan ID i Ime, prvo provjeravam postoji li clan s tim ID-om i s tim Imenom, ako postoji brisemo ga
            else if (ID > 0 && Ime.Length > 0 && Prezime.Length == 0 && OIB.Length == 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime", connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ime", Ime);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);
               
                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID i Prezime, prvo provjeravam postoji li clan s tim ID-om i s tim Prezimenom, ako postoji brisemo ga
            else if (ID > 0 && Ime.Length == 0 && Prezime.Length > 0 && OIB.Length == 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Prezime = @prezime", connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@prezime", Prezime);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID i OIB, prvo provjeravam postoji li clan s tim ID-om i s tim OIB-om, ako postoji brisemo ga
            else if (ID > 0 && Ime.Length == 0 && Prezime.Length == 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@oib", OIB);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID, Ime i Prezime, prvo provjeravam postoji li clan s tim ID-om i s tim OIB-om, ako postoji brisemo ga
            else if (ID > 0 && Ime.Length > 0 && Prezime.Length > 0 && OIB.Length == 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.Prezime = @prezime", connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ime", Ime);
                cmd.Parameters.AddWithValue("@prezime", Prezime);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID, Ime i OIB, prvo provjeravam postoji li clan s tim ID-om i s tim OIB-om, ako postoji brisemo ga
            else if (ID > 0 && Ime.Length > 0 && Prezime.Length == 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ime", Ime);
                cmd.Parameters.AddWithValue("@oib", OIB);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadan ID, Prezime i OIB, prvo provjeravam postoji li clan s tim ID-om i s tim OIB-om, ako postoji brisemo ga
            else if (ID > 0 && Ime.Length == 0 && Prezime.Length > 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@prezime", Prezime);
                cmd.Parameters.AddWithValue("@oib", OIB);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }
            // Ukoliko je zadan samo OIB, prvo provjeravam postoji li clan s tim OIB-om, ako postoji brisemo ga
            else if (ID == 0 && Ime.Length == 0 && Prezime.Length == 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@oib", OIB);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                    cmd.Parameters.AddWithValue("@oib", OIB);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);

                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadano Ime i OIB, prvo provjeravam postoji li clan s tim Imenom i OIB-om, ako postoji brisemo ga
            else if (ID == 0 && Ime.Length > 0 && Prezime.Length == 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@ime", Ime);
                cmd.Parameters.AddWithValue("@oib", OIB);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                    cmd.Parameters.AddWithValue("@oib", OIB);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);

                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadano Prezime i OIB, prvo provjeravam postoji li clan s tim Prezimenom i OIB-om, ako postoji brisemo ga
            else if (ID == 0 && Ime.Length == 0 && Prezime.Length > 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@prezime", Prezime);
                cmd.Parameters.AddWithValue("@oib", OIB);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                    cmd.Parameters.AddWithValue("@oib", OIB);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);

                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko je zadano Ime, Prezime i OIB, prvo provjeravam postoji li clan s tim Imenom, Prezimenom i OIB-om, ako postoji brisemo ga
            else if (ID == 0 && Ime.Length > 0 && Prezime.Length > 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@ime", Ime);
                cmd.Parameters.AddWithValue("@prezime", Prezime);
                cmd.Parameters.AddWithValue("@oib", OIB);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    cmd = new SqlCommand("SELECT Clan.ClanID FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Osoba.OIB = @oib", connection);
                    cmd.Parameters.AddWithValue("@oib", OIB);

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    int id = dr.GetInt32(0);

                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            // Ukoliko su zadani svi podaci, prvo provjeravam postoji li clan s tim podacima, ako postoji brisemo ga
            else if (ID > 0 && Ime.Length > 0 && Prezime.Length > 0 && OIB.Length > 0)
            {
                cmd = new SqlCommand("SELECT Clan.ClanID, Osoba.Ime, Osoba.Prezime, Osoba.OIB FROM Osoba INNER JOIN Clan ON Osoba.OsobaID = Clan.OsobaID WHERE Clan.ClanID = @id AND Osoba.Ime = @ime AND Osoba.Prezime = @prezime AND Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ime", Ime);
                cmd.Parameters.AddWithValue("@prezime", Prezime);
                cmd.Parameters.AddWithValue("@oib", OIB);

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                  
                    cmd = new SqlCommand("DELETE FROM Clan WHERE Clan.ClanID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Član obrisan.");
                    
                }
                else
                {
                    MessageBox.Show("Član s tim podacima ne postoji!");
                }
            }

            connection.Close();
            
        }

    }
}
