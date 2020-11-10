using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientCreate_Click(object sender, EventArgs e)
        {
            createClient cc = new createClient(clientName.Text, clientSurname.Text, Convert.ToInt32(clientTlf.Text), clientEmail.Text, clientCity.Text, clientAdress.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetClients();
        }

        private void GetClients()
        {
            string[] arr = { "Adresse", "KundeID", "Navn", "Efternavn", "City", "Telefon" };
            List<ListViewItem> itemsArr = new List<ListViewItem>();
            showClients sc = new showClients();
            showWindow sw = new showWindow(arr, sc.ReturnList());
            sw.Clear();
            sw.Bounds = new Rectangle(new Point(10, 10), new Size(800, 500));
            sw.View = View.Details;
            sw.LabelEdit = true;
            sw.AllowColumnReorder = true;
            sw.FullRowSelect = true;
            sw.GridLines = true;
            sw.Sorting = SortOrder.Ascending;
            sw.Columns.Add("*", 4, HorizontalAlignment.Left);
            foreach (string column in arr)
            {
                sw.Columns.Add(column.ToString(), 100, HorizontalAlignment.Left);
            }
            foreach (ListViewItem item in sc.ReturnList())
            {
                sw.Items.Add(item);
            }
            this.Controls.Add(sw);
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {/*
                if(sw.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
                */
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sletKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateCarView(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = { "VIN", "Farve", "Mærke", "Model", "Årgang", "UniqueID", "City" };
            List<ListViewItem> itemsArr = new List<ListViewItem>();
            ShowCars sc = new ShowCars();
            showWindow sw = new showWindow(arr, sc.ReturnList());
            sw.Clear();
            sw.Bounds = new Rectangle(new Point(10, 10), new Size(800, 500));
            sw.View = View.Details;
            sw.LabelEdit = true;
            sw.AllowColumnReorder = true;
            sw.FullRowSelect = true;
            sw.GridLines = true;
            sw.Sorting = SortOrder.Ascending;
            sw.Columns.Add("*", 4, HorizontalAlignment.Left);
            foreach (string column in arr)
            {
                sw.Columns.Add(column.ToString(), 100, HorizontalAlignment.Left);
            }
            foreach (ListViewItem item in sc.ReturnList())
            {
                sw.Items.Add(item);
            }
            this.Controls.Add(sw);
        }
    }
}