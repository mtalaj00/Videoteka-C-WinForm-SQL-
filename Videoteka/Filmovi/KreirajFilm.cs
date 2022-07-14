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
    class KreirajFilm
    {
        public KreirajFilm(TextBox textBoxNaziv, TextBox textBoxGodinaIzlaska, TextBox textBoxOcjena)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxNaziv.Text) || String.IsNullOrEmpty(textBoxGodinaIzlaska.Text) || String.IsNullOrEmpty(textBoxOcjena.Text))
                {
                    MessageBox.Show("Molimo popunite potrebna polja.\nPolje ID treba ostati prazno.");
                }
                else
                {
                    Film film = new Film();

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
                    connection.Open();

                    film.setNaziv(textBoxNaziv.Text);
                    film.setGodinaIzlaska(int.Parse(textBoxGodinaIzlaska.Text));
                    film.setOcjena(double.Parse(textBoxOcjena.Text));

                    // Provjeravam postoji li film s tim nazivom i godinom izlaska, ocjenu ne provjeravam zbog toga da se ne bi dodao isti film samo s drugom ocjenom
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Film WHERE Film.Naziv = @naziv AND Film.GodinaIzdanja = @godina", connection);
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Film s tim podacima već postoji.");
                    }
                    else
                    {
                        String Sifra = String.Concat(film.getNaziv(),film.getGodinaIzlaska());                                            

                        cmd = new SqlCommand("INSERT INTO Film VALUES (@sifra, @naziv, @godina, @ocjena)", connection);
                        cmd.Parameters.AddWithValue("@sifra", Sifra);
                        cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                        cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());
                        cmd.Parameters.AddWithValue("@ocjena", film.getOcjena());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Uspješno ste dodali novi film.");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
