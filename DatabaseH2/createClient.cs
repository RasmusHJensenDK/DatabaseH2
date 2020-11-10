using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseH2
{
    class createClient
    {
        private string _NAME { get; set; }
        private string _SURNAME { get; set; }
        private int _TELEFON { get; set; }
        private string _EMAIL { get; set; }
        private string _ADRESS { get; set; }
        private string _CITY { get; set; }
        public createClient(string _NAME, string _SURNAME, int _TELEFON, string _EMAIL, string _ADRESS, string _CITY)
        {
            this._NAME = _NAME;
            this._SURNAME = _SURNAME;
            this._TELEFON = _TELEFON;
            this._EMAIL = _EMAIL;
            this._ADRESS = _ADRESS;
            this._CITY = _CITY;

            Kunder nykunde = new Kunder(_NAME, _SURNAME, _TELEFON, _ADRESS, _CITY);
            try
            {
                DatabaseWrapper wr = new DatabaseWrapper("Data Source=01BIBME14RHJ;Initial Catalog=H2DatabaseRefreshed;Integrated Security=True");
                wr.ExecuteQuery($"INSERT INTO dbo.vKunder (Navn,Efternavn,Telefon,Adresse,City) VALUES('{nykunde.returnNavn()}','{nykunde.returnEfter()}', '{nykunde.returnTlf()}','{nykunde.returnCity()}','{nykunde.returnAdresse()}')");
            }
            catch (Exception c)
            {
                Console.Write(c.Message);
            }
        }
    }
}
