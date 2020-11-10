using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseH2
{
    class ShowCars
    {
        private List<ListViewItem> itemsArr = new List<ListViewItem>();
        public ShowCars()
        {
            ShowCarsToList();
        }
        public void ShowCarsToList()
        {
            try
            {
                DatabaseWrapper wr = new DatabaseWrapper("Data Source=01BIBME14RHJ;Initial Catalog=H2DatabaseRefreshed;Integrated Security=True");
                wr.ExecuteReadQuery($"SELECT * FROM dbo.vCarLocation");
                foreach (Biler bil in wr.BilListe)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(bil.returnVIN().ToString());
                    lvi.SubItems.Add(bil.returnFarve());
                    lvi.SubItems.Add(bil.returnMærke());
                    lvi.SubItems.Add(bil.returnModel().ToString());
                    lvi.SubItems.Add(bil.returnID().ToString());
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
