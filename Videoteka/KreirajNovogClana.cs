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
        private String Ime;
        private String Prezime;
        private String OIB;


        public void setIme(String ime)
        {
            this.Ime = ime;
        }
        public String getIme()
        {
            return this.Ime;
        }

        public void setPrezime(String Prezime)
        {
            this.Prezime = Prezime;
        }
        public String getPrezime()
        {
            return this.Prezime;
        }

        public void setOIB(String OIB)
        {
            this.OIB = OIB;
        }
        public String getOIB()
        {
            return this.OIB;
        }


        public KreirajNovogClana(String ime, String prezime, String oib)
        {
            setIme(ime);
            setPrezime(prezime);
            setOIB(oib);

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Videoteka;Integrated Security=True");
                connection.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO Osoba VALUES (@ime, @prezime, @oib)", connection);

                cmd.Parameters.AddWithValue("@ime", getIme());
                cmd.Parameters.AddWithValue("@prezime", getPrezime());
                cmd.Parameters.AddWithValue("@oib", getOIB());

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT Osoba.OsobaID FROM Osoba WHERE Osoba.OIB = @oib", connection);
                cmd.Parameters.AddWithValue("@oib", getOIB());

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
