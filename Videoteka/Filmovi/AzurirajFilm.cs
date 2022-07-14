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
    class AzurirajFilm
    {
        public AzurirajFilm(TextBox textBoxID, TextBox textBoxNaziv, TextBox textBoxGodinaIzlaska, TextBox textBoxOcjena)
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Unesite ID filma kojem želite promjeniti podatke.");
            }
            else if ((String.IsNullOrEmpty(textBoxNaziv.Text) && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) && String.IsNullOrEmpty(textBoxOcjena.Text)))
            {
                MessageBox.Show("Unesite podatke koje želite promjeniti.");
            }
            else
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    // Kada mijenjamo samo Naziv, prvo provjeravam postoji li film s unesenim ID-om
                    if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) == false && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) && String.IsNullOrEmpty(textBoxOcjena.Text))
                    {
                        cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id", connection);
                        cmd.Parameters.AddWithValue("@id",int.Parse(textBoxID.Text));

                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            cmd = new SqlCommand("UPDATE Film SET Naziv = @naziv WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                            cmd.Parameters.AddWithValue("@naziv", textBoxNaziv.Text);                            

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Uspješno izmjenjeno.");
                        }
                        else
                        {
                            MessageBox.Show("Film s tim ID-om ne postoji!");
                        }
                    }

                    // Kada mijenjamo samo Godinu izlaska, prvo provjeravam postoji li film s unesenim ID-om
                    if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) == false && String.IsNullOrEmpty(textBoxOcjena.Text))
                    {
                        cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            cmd = new SqlCommand("UPDATE Film SET GodinaIzdanja = @godina WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                            cmd.Parameters.AddWithValue("@godina", int.Parse(textBoxGodinaIzlaska.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Uspješno izmjenjeno.");
                        }
                        else
                        {
                            MessageBox.Show("Film s tim ID-om ne postoji!");
                        }
                    }

                    // Kada mijenjamo samo Ocjenu, prvo provjeravam postoji li film s unesenim ID-om
                    if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) && String.IsNullOrEmpty(textBoxOcjena.Text) == false)
                    {
                        cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            cmd = new SqlCommand("UPDATE Film SET Ocjena = @ocjena WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                            cmd.Parameters.AddWithValue("@ocjena", double.Parse(textBoxOcjena.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Uspješno izmjenjeno.");
                        }
                        else
                        {
                            MessageBox.Show("Film s tim ID-om ne postoji!");
                        }
                    }

                    // Kada mijenjamo Naziv i Godinu izlaska, prvo provjeravam postoji li film s unesenim ID-om
                    if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) == false && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) == false && String.IsNullOrEmpty(textBoxOcjena.Text))
                    {
                        cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            cmd = new SqlCommand("UPDATE Film SET Naziv = @naziv, GodinaIzdanja = @godina WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                            cmd.Parameters.AddWithValue("@naziv", textBoxNaziv.Text);
                            cmd.Parameters.AddWithValue("@godina", int.Parse(textBoxGodinaIzlaska.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Uspješno izmjenjeno.");
                        }
                        else
                        {
                            MessageBox.Show("Film s tim ID-om ne postoji!");
                        }
                    }

                    // Kada mijenjamo Naziv i Ocjenu, prvo provjeravam postoji li film s unesenim ID-om
                    if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) == false && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) && String.IsNullOrEmpty(textBoxOcjena.Text) == false)
                    {
                        cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            cmd = new SqlCommand("UPDATE Film SET Naziv = @naziv, Ocjena = @ocjena WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                            cmd.Parameters.AddWithValue("@naziv", textBoxNaziv.Text);
                            cmd.Parameters.AddWithValue("@ocjena", double.Parse(textBoxOcjena.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Uspješno izmjenjeno.");
                        }
                        else
                        {
                            MessageBox.Show("Film s tim ID-om ne postoji!");
                        }
                    }

                    // Kada mijenjamo Godinu izlaska i Ocjenu, prvo provjeravam postoji li film s unesenim ID-om
                    if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) == false && String.IsNullOrEmpty(textBoxOcjena.Text) == false)
                    {
                        cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            cmd = new SqlCommand("UPDATE Film SET GodinaIzdanja = @godina, Ocjena = @ocjena WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                            cmd.Parameters.AddWithValue("@godina", int.Parse(textBoxGodinaIzlaska.Text));
                            cmd.Parameters.AddWithValue("@ocjena", double.Parse(textBoxOcjena.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Uspješno izmjenjeno.");
                        }
                        else
                        {
                            MessageBox.Show("Film s tim ID-om ne postoji!");
                        }
                    }

                    // Kada mijenjamo sve podatke, prvo provjeravam postoji li film s unesenim ID-om
                    if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) == false && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) == false && String.IsNullOrEmpty(textBoxOcjena.Text) == false)
                    {
                        cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id", connection);
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            cmd = new SqlCommand("UPDATE Film SET Naziv = @naziv, GodinaIzdanja = @godina, Ocjena = @ocjena WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                            cmd.Parameters.AddWithValue("@naziv", textBoxNaziv.Text);
                            cmd.Parameters.AddWithValue("@godina", int.Parse(textBoxGodinaIzlaska.Text));
                            cmd.Parameters.AddWithValue("@ocjena", double.Parse(textBoxOcjena.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Uspješno izmjenjeno.");
                        }
                        else
                        {
                            MessageBox.Show("Film s tim ID-om ne postoji!");
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
