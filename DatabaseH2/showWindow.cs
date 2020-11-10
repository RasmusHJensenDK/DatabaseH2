using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseH2
{
    
    class showWindow: ListView
    {
        private ListView listView = new ListView();
        private List<ListViewItem> listViewItemsNow = new List<ListViewItem>();
        private string[] columns;
        
        public showWindow(string[] columns, List<ListViewItem> items)
        {
            this.columns = columns;
            foreach(ListViewItem litem in items)
            {
                listViewItemsNow.Add(litem);
            }
        }

        public ListView createListView()
        {
            this.listView.Clear();
            this.listView.Bounds = new Rectangle(new Point(10, 10), new Size(500, 500));
            this.listView.View = View.Details;
            this.listView.LabelEdit = true;
            this.listView.AllowColumnReorder = true;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Sorting = SortOrder.Ascending;
            this.listView.Columns.Add("*", 4, HorizontalAlignment.Left);
            foreach (string column in columns)
            {
                this.listView.Columns.Add(column.ToString(), 100, HorizontalAlignment.Left);
            }
            
            foreach (ListViewItem item in listViewItemsNow)
            {
                listView.Items.Add(item);
            }
            
            return listView;
        }
    }
}