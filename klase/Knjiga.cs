using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.klase
{
    [Serializable]
    class Knjiga 
    {
        private string naziv;
        private string pisac;
        private int brojStrana;
        private string izdavac;
        private bool procitana;

        public string Naziv { get => naziv; }
        public string Pisac { get => pisac;}
        public int BrojStrana { get => brojStrana; }
        public string Izdavac { get => izdavac; }
        public bool Procitana { get => procitana; set => procitana = value; }

        public Knjiga()
        {

        }
        public Knjiga (string naziv, string pisac, int brojStrana, string izdavac)
        {
            this.naziv = naziv;
            this.pisac = pisac;
            this.brojStrana = brojStrana;
            this.izdavac = izdavac;
        }

        public string getAllInfo()
        {
            return string.Format("{0,-30}  {1,-20}  {2,-12}  {3,-10}", Naziv, Pisac, BrojStrana,Izdavac);
        }

      
    }
}
