using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseH2
{
    class showClients
    {
        private List<ListViewItem> itemsArr = new List<ListViewItem>();
        public showClients()
        {
            ShowClients();
        }
        public void ShowClients()
        {
            try
            {
                DatabaseWrapper wr = new DatabaseWrapper("Data Source=01BIBME14RHJ;Initial Catalog=H2DatabaseRefreshed;Integrated Security=True");
                wr.ExecuteReadQuery($"SELECT * FROM dbo.vKunder");
                foreach (Kunder kunde in wr.Kundeliste)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(kunde.returnKundeID().ToString());
                    lvi.SubItems.Add(kunde.returnNavn());
                    lvi.SubItems.Add(kunde.returnEfter());
                    lvi.SubItems.Add(kunde.returnTlf().ToString());
                    lvi.SubItems.Add(kunde.returnCity());
                    lvi.SubItems.Add(kunde.returnAdresse());
                    itemsArr.Add(lvi);
                }
            }
            catch (Exception b)
            {
             //   throw b.Message;
            }
        }

        public List<ListViewItem> ReturnList()
        {
            return itemsArr;
        }

    }
}
