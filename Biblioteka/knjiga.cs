using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    internal class knjiga
    {
        int isbn, godina_izdavanja, broj_kopija;
        string naziv, pisac, izdavac;

        public knjiga(string naziv,int isbn, int godina_izdavanja, int broj_kopija, string pisac, string izdavac)
        {
            this.Naziv = naziv;
            this.Isbn = isbn;
            this.Godina_izdavanja = godina_izdavanja;
            this.Broj_kopija = broj_kopija;
            this.Pisac = pisac;
            this.Izdavac = izdavac;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public int Godina_izdavanja { get => godina_izdavanja; set => godina_izdavanja = value; }
        public int Broj_kopija { get => broj_kopija; set => broj_kopija = value; }
        public string Pisac { get => pisac; set => pisac = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }


    }
}
