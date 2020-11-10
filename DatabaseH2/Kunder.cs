using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseH2
{
    class Kunder
    {
        private string Navn { get; set; }
        private string Efternavn { get; set; }
        private int Telefon { get; set; }
        private string Adresse { get; set; }
        private string City { get; set; }
        private string KundeID { get; set; }

        public Kunder(string Navn, string Efternavn, int Telefon, string Adresse, string City, string KundeID = "")
        {
            this.KundeID = KundeID.ToString();
            this.Navn = Navn.ToString();
            this.Efternavn = Efternavn.ToString();
            this.Adresse = Adresse.ToString();
            this.City = City.ToString();
            this.Telefon = Telefon;
        }

        public string returnNavn()
        {
            return this.Navn;
        }

        public string returnEfter()
        {
            return this.Efternavn;
        }

        public int returnTlf()
        {
            return this.Telefon;
        }


        public string returnAdresse()
        {
            return this.Adresse;
        }

        public string returnCity()
        {
            return this.City;
        }
        public string returnKundeID()
        {
            return this.KundeID;
        }
    }
}
