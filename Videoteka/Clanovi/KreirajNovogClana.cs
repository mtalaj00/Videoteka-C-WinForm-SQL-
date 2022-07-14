using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    class KreirajNovogClana
    {       
        public KreirajNovogClana(String ime, String prezime, String oib)
        {
            Osoba osoba = new Osoba();

            osoba.setIme(ime);
            osoba.setPrezime(prezime);
            osoba.setOIB(oib);

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
                connection.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO Osoba VALUES (@ime, @prezime, @oib)", connection);

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

                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



    }
}
