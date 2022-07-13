using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka
{
    class Osoba
    {
        private int ID;
        private String Ime;
        private String Prezime;
        private String OIB;


        public void setID(int ID)
        {
            this.ID = ID;
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

        public void setOIB(String OIB)
        {
            this.OIB = OIB;
        }
        public String getOIB()
        {
            return this.OIB;
        }
    }
}
