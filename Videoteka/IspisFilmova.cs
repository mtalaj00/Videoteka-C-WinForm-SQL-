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
    class IspisFilmova
    {
        Film film = new Film();

        public IspisFilmova(TextBox textBoxId, TextBox textBoxNaziv, TextBox textBoxGodinaIzlaska, TextBox textBoxOcjena, DataGridView dataGridView)
        {
            if (String.IsNullOrEmpty(textBoxId.Text))
            {
                film.setID(0);
            }
            else
            {
                film.setID(int.Parse(textBoxId.Text));
            }
            if (String.IsNullOrEmpty(textBoxNaziv.Text))
            {
                film.setNaziv("");
            }
            else
            {
                film.setNaziv(textBoxNaziv.Text);

            }
            if (String.IsNullOrEmpty(textBoxGodinaIzlaska.Text))
            {
                film.setGodinaIzlaska(0);
            }
            else
            {
                film.setGodinaIzlaska(int.Parse(textBoxGodinaIzlaska.Text));
            }
            if (String.IsNullOrEmpty(textBoxOcjena.Text))
            {
                film.setOcjena(0);
            }
            else
            {
                film.setOcjena(double.Parse(textBoxOcjena.Text));
            }



            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
                connection.Open();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();


                //  ISPIS SVIH FILMOVA AKO NEMA UNESENIH PODATAKA
                if (film.getID() == 0 && film.getNaziv().Length == 0 && film.getGodinaIzlaska() == 0 && film.getOcjena() == 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film", connection);
                }

                //  ISPIS PREMA ID-u
                else if (film.getID() > 0 && film.getNaziv().Length == 0 && film.getGodinaIzlaska() == 0 && film.getOcjena() == 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.FilmID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", film.getID());
                }

                //  ISPIS PREMA NAZIVU
                else if (film.getID() == 0 && film.getNaziv().Length > 0 && film.getGodinaIzlaska() == 0 && film.getOcjena() == 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.Naziv = @naziv", connection);
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                }


                //  ISPIS PREMA GODINI IZLASKA
                else if (film.getID() == 0 && film.getNaziv().Length == 0 && film.getGodinaIzlaska() > 0 && film.getOcjena() == 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.GodinaIzdanja = @godina", connection);
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());
                }
                
                //  ISPIS PREMA OCJENI
                else if (film.getID() == 0 && film.getNaziv().Length == 0 && film.getGodinaIzlaska() == 0 && film.getOcjena() > 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.Ocjena = @cjena", connection);
                    cmd.Parameters.AddWithValue("@cjena", film.getOcjena());
                }

                //  ISPIS PREMA ID-u I NAZIVU
                else if (film.getID() > 0 && film.getNaziv().Length > 0 && film.getGodinaIzlaska() == 0 && film.getOcjena() == 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.FilmID = @id AND Film.Naziv = @naziv", connection);
                    cmd.Parameters.AddWithValue("@id", film.getID());
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                }

                //  ISPIS PREMA ID-u I GODINI IZLASKA
                else if (film.getID() > 0 && film.getNaziv().Length == 0 && film.getGodinaIzlaska() > 0 && film.getOcjena() == 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.FilmID = @id AND Film.GodinaIzdanja = @godina", connection);
                    cmd.Parameters.AddWithValue("@id", film.getID());
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());
                }

                //  ISPIS PREMA ID-u I OCJENI
                else if (film.getID() > 0 && film.getNaziv().Length == 0 && film.getGodinaIzlaska() == 0 && film.getOcjena() > 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.FilmID = @id AND Film.Ocjena = @cjena", connection);
                    cmd.Parameters.AddWithValue("@id", film.getID());
                    cmd.Parameters.AddWithValue("@cjena", film.getOcjena());
                }

                //  ISPIS PREMA NAZIVU I GODINI IZLASKA
                else if (film.getID() == 0 && film.getNaziv().Length > 0 && film.getGodinaIzlaska() > 0 && film.getOcjena() == 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.Naziv = @naziv AND Film.GodinaIzdanja = @godina", connection);
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());
                }

                //  ISPIS PREMA NAZIVU I OCJENI
                else if (film.getID() == 0 && film.getNaziv().Length > 0 && film.getGodinaIzlaska() == 0 && film.getOcjena() > 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.Naziv = @naziv AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                    cmd.Parameters.AddWithValue("@ocjena", film.getOcjena());
                }

                //  ISPIS PREMA GODINI IZLASKA I OCJENI
                else if (film.getID() == 0 && film.getNaziv().Length == 0 && film.getGodinaIzlaska() > 0 && film.getOcjena() > 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.GodinaIzdanja = @godina AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());
                    cmd.Parameters.AddWithValue("@ocjena", film.getOcjena());
                }

                //  ISPIS PREMA ID-u,NAZIVU i GODINI IZLASKA
                else if (film.getID() > 0 && film.getNaziv().Length > 0 && film.getGodinaIzlaska() > 0 && film.getOcjena() == 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.FilmID = @id AND Film.Naziv = @naziv AND Film.GodinaIzdanja = @godina", connection);
                    cmd.Parameters.AddWithValue("@id", film.getID());
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());                    
                }

                //  ISPIS PREMA ID-u, NAZIVU i OCJENI
                else if (film.getID() > 0 && film.getNaziv().Length > 0 && film.getGodinaIzlaska() == 0 && film.getOcjena() > 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.FilmID = @id AND Film.Naziv = @naziv AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@id", film.getID());
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                    cmd.Parameters.AddWithValue("@ocjena", film.getOcjena());
                }

                //  ISPIS PREMA ID-u, GODINI IZLASKA I OCJENI
                else if (film.getID() > 0 && film.getNaziv().Length == 0 && film.getGodinaIzlaska() > 0 && film.getOcjena() > 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.FilmID = @id AND Film.GodinaIzdanja = @godina AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@id", film.getID());
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());
                    cmd.Parameters.AddWithValue("@ocjena", film.getOcjena());
                }

                //  ISPIS PREMA NAZIVU, GODINI IZLASKA i OCJENI
                else if (film.getID() == 0 && film.getNaziv().Length > 0 && film.getGodinaIzlaska() > 0 && film.getOcjena() > 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.Naziv = @naziv AND Film.GodinaIzdanja = @godina AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());
                    cmd.Parameters.AddWithValue("@ocjena", film.getOcjena());
                }

                //  ISPIS PREMA SVIM PODACIMA
                else if (film.getID() > 0 && film.getNaziv().Length > 0 && film.getGodinaIzlaska() > 0 && film.getOcjena() > 0)
                {
                    cmd = new SqlCommand("SELECT Film.FilmID, Film.Naziv,Film.GodinaIzdanja AS Godina_Izlaska, Film.Ocjena FROM Film WHERE Film.FilmID = @id AND Film.Naziv = @naziv AND Film.GodinaIzdanja = @godina AND Film.Ocjena = @ocjena", connection);
                    cmd.Parameters.AddWithValue("@id", film.getID());
                    cmd.Parameters.AddWithValue("@naziv", film.getNaziv());
                    cmd.Parameters.AddWithValue("@godina", film.getGodinaIzlaska());
                    cmd.Parameters.AddWithValue("@ocjena", film.getOcjena());
                }


                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                dataGridView.DataSource = table;

                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }








        }
    }
}
