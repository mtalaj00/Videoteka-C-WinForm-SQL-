using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka
{
    class Film
    {
        private int ID;
        private String Naziv;
        private int GodinaIzlaska;
        private double Ocjena;

        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return this.ID;
        }
        public void setNaziv(String naziv)
        {
            this.Naziv = naziv;
        }
        public String getNaziv()
        {
            return this.Naziv;
        }
        public void setGodinaIzlaska(int godinaIzlaska)
        {
            this.GodinaIzlaska = godinaIzlaska;
        }
        public int getGodinaIzlaska()
        {
            return this.GodinaIzlaska;
        }
        public void setOcjena(double ocjena)
        {
            this.Ocjena = ocjena;
        }
        public double getOcjena()
        {
            return this.Ocjena;
        }
    }
}
