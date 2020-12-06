using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.klase
{
    class Skladiste
    {
        private List<Knjiga> knjige = new List<Knjiga>();

        public List<Knjiga> Knjige
        {
            get { return knjige; }
        }

        public void dodajKnjiguUlistu (Knjiga k)
        {
            knjige.Add(k);
        }
        public void ukloniKnjigu(Knjiga k)
        {
            knjige.Remove(k);
        }

        public void sortByNaziv_A_Z()//for sorting the list
        {

            knjige.Sort(delegate (Knjiga x, Knjiga y)
            {
                return x.Naziv.CompareTo(y.Naziv);
            });

        }

        public void sortByNaziv_Z_A()//for sorting the list
        {

            knjige.Sort(delegate (Knjiga x, Knjiga y)
            {
                return y.Naziv.CompareTo(x.Naziv);
            });

        }


        public void sortByPisac_A_Z()//for sorting the list
        {

            knjige.Sort(delegate (Knjiga x, Knjiga y)
            {
                return x.Pisac.CompareTo(y.Pisac);
            });

        }
        public void sortByPisac_Z_A()//for sorting the list
        {

            knjige.Sort(delegate (Knjiga x, Knjiga y)
            {
                return y.Pisac.CompareTo(x.Pisac);
            });

        }

        public void sortByBrojStranaRastuce()//for sorting the list
        {

            knjige.Sort(delegate (Knjiga x, Knjiga y)
            {
                return x.BrojStrana.CompareTo(y.BrojStrana);
            });

        }
        public void sortByBrojStranaOpadajuce()//for sorting the list
        {

            knjige.Sort(delegate (Knjiga x, Knjiga y)
            {
                return y.BrojStrana.CompareTo(x.BrojStrana);
            });

        }

        public void sortByIzdavac_A_Z()//for sorting the list
        {

            knjige.Sort(delegate (Knjiga x, Knjiga y)
            {
                return x.Izdavac.CompareTo(y.Izdavac);
            });

        }
        public void sortByIzdavac_Z_A()//for sorting the list
        {

            knjige.Sort(delegate (Knjiga x, Knjiga y)
            {
                return y.Izdavac.CompareTo(x.Izdavac);
            });

        }
    }
}
