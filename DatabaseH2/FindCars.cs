using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseH2
{
    class FindCars
    {
        private string CarModel { get; set; }
        private string carBrand { get; set; }
        private List<Biler> BilListe = new List<Biler>();
        public List<Biler> GetCars()
        {
            try
            {
                DatabaseWrapper wr = new DatabaseWrapper("Data Source=01BIBME14RHJ;Initial Catalog=H2DatabaseRefreshed;Integrated Security=True");
                wr.ExecuteReadQuery($"SELECT * FROM dbo.Personer");
                foreach (Kunder kunde in wr.Kundeliste)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(kunde.returnNavn());
                    lvi.SubItems.Add(kunde.returnEfter());
                    lvi.SubItems.Add(kunde.returnTlf().ToString());
                }
            }
            catch (Exception b)
            {
            }
            return BilListe;
        }
    }
}
