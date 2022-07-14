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
    class IzbrisiFilm
    {
        public IzbrisiFilm(TextBox textBoxID, TextBox textBoxNaziv, TextBox textBoxGodinaIzlaska, TextBox textBoxOcjena)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            try
            {
                if (String.IsNullOrEmpty(textBoxID.Text))
                {
                    MessageBox.Show("Morate unijeti ID ukoliko želite izbrisati film.");
                }

                // Ukoliko je zadan samo ID, provjeravam postoji li film s tim ID-om, ako postoji brisemo ga
                else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) && String.IsNullOrEmpty(textBoxOcjena.Text))
                {
                    cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovoj film ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("DELETE FROM Film WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film obrisan.");
                            
                        }

                    }
                    else
                    {
                        MessageBox.Show("Film s tim ID-om ne postoji!");
                    }
                }

                // Ukoliko je zadan ID i Naziv filma, provjeravam postoji li film s tim ID-om i Nazivom, ako postoji brisemo ga
                else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) == false && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) && String.IsNullOrEmpty(textBoxOcjena.Text))
                {
                    cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id AND Film.Naziv = @naziv", connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@naziv", textBoxNaziv.Text);

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovoj film ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("DELETE FROM Film WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film obrisan.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Film s tim podacima ne postoji!");
                    }
                }

                // Ukoliko je zadan ID i Godina izlaska filma, provjeravam postoji li film s tim ID-om i Godinom izlaska, ako postoji brisemo ga
                else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) == false && String.IsNullOrEmpty(textBoxOcjena.Text))
                {
                    cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id AND Film.GodinaIzdanja = @godina", connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@godina", int.Parse(textBoxGodinaIzlaska.Text));

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovoj film ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("DELETE FROM Film WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film obrisan.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Film s tim podacima ne postoji!");
                    }
                }

                // Ukoliko je zadan ID i Ocjena, provjeravam postoji li film s tim ID-om i ocjenom, ako postoji brisemo ga
                else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) && String.IsNullOrEmpty(textBoxOcjena.Text) == false)
                {
                    cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@ocjena", double.Parse(textBoxOcjena.Text));

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovoj film ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("DELETE FROM Film WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film obrisan.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Film s tim podacima ne postoji!");
                    }
                }

                // Ukoliko je zadan ID, Naziv i Godina izlaska filma, provjeravam postoji li film s tim ID-om, Nazivom i Godinom izlaska, ako postoji brisemo ga
                else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) == false && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) == false && String.IsNullOrEmpty(textBoxOcjena.Text))
                {
                    cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id AND Film.Naziv = @naziv AND Film.GodinaIzdanja = @godina", connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@naziv", textBoxNaziv.Text);
                    cmd.Parameters.AddWithValue("@godina", int.Parse(textBoxGodinaIzlaska.Text));

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovoj film ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("DELETE FROM Film WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film obrisan.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Film s tim podacima ne postoji!");
                    }
                }

                // Ukoliko je zadan ID, Naziv i Ocjena, provjeravam postoji li film s tim ID-om, Nazivom i Ocjenom, ako postoji brisemo ga
                else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) == false && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) && String.IsNullOrEmpty(textBoxOcjena.Text) == false)
                {
                    cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id AND Film.Naziv = @naziv AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@naziv", textBoxNaziv.Text);
                    cmd.Parameters.AddWithValue("@ocjena", double.Parse(textBoxOcjena.Text));

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovoj film ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("DELETE FROM Film WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film obrisan.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Film s tim podacima ne postoji!");
                    }
                }

                // Ukoliko je zadan ID, Godina izlaska i Ocjena, provjeravam postoji li film s tim ID-om, Godinom izlaska i Ocjenom, ako postoji brisemo ga
                else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) == false && String.IsNullOrEmpty(textBoxOcjena.Text) == false)
                {
                    cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id AND Film.GodinaIzdanja = @godina AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@godina", int.Parse(textBoxGodinaIzlaska.Text));
                    cmd.Parameters.AddWithValue("@ocjena", double.Parse(textBoxOcjena.Text));

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovoj film ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("DELETE FROM Film WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film obrisan.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Film s tim podacima ne postoji!");
                    }
                }

                // Ukoliko su zadani svi podaci, provjeravam postoji li film s tim podacima, ako postoji brisemo ga
                else if (String.IsNullOrEmpty(textBoxID.Text) == false && String.IsNullOrEmpty(textBoxNaziv.Text) == false && String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) == false && String.IsNullOrEmpty(textBoxOcjena.Text) == false)
                {
                    cmd = new SqlCommand("SELECT * FROM Film WHERE Film.FilmID = @id AND Film.Naziv = @naziv AND Film.GodinaIzdanja = @godina AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@naziv", textBoxNaziv.Text);
                    cmd.Parameters.AddWithValue("@godina", int.Parse(textBoxGodinaIzlaska.Text));
                    cmd.Parameters.AddWithValue("@ocjena", double.Parse(textBoxOcjena.Text));

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Jeste li sigurni da želite ukloniti ovoj film ?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("DELETE FROM Film WHERE Film.FilmID = @id", connection);
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Film obrisan.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Film s tim podacima ne postoji!");
                    }
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}


