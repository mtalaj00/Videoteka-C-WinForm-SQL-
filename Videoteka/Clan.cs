using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    class Ispis : Form
    {
        private int ID;
        private String Ime;
        private String Prezime;
        private char[] OIB;

        public Ispis()
        {
            
        }


        public void setID(int id)
        {
            this.ID = id;
        }
        public int getID()
        {
            return this.ID;
        }

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

        public void setOIB(char[] OIB)
        {
            this.OIB = OIB;
        }
        public char[] getOIB()
        {
            return this.OIB;
        }


       



    }
}
