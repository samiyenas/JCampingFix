using JCampingFix.Controller;
using JCampingFix.Service;
using JCampingFix.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCampingFix.View
{
    public partial class BokaStuga : Form
    {
        CabinList cabinList;
        CustomerList customerList;
        public BokaStuga()
        {
            
            InitializeComponent();
            cabinList = ServiceProvider.GetCabinService();
            customerList = ServiceProvider.GetCustomerService();
            initListView();
            lvwBokaKund.HideSelection = false;
            lvwBokaStuga.HideSelection = false;
        }
        
        private void initListView()
        {
            //Initializar listviewen för stugorna
            lvwBokaStuga.FullRowSelect = true;
            lvwBokaStuga.GridLines = true;
            lvwBokaStuga.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwBokaStuga.Columns.Add("Stugnamn", -2, HorizontalAlignment.Left);
            lvwBokaStuga.Columns.Add("Ledig", -2, HorizontalAlignment.Left);
            lvwBokaStuga.Columns.Add("Ledig från", -2, HorizontalAlignment.Left);

            //Initializar listviewen för kunderna
            lvwBokaKund.FullRowSelect = true;
            lvwBokaKund.GridLines = true;
            lvwBokaKund.Columns.Add("Förnamn", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Efternamn", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Adress ", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Telefonnummer", -2, HorizontalAlignment.Left);

            //Kallar på en update för att fylla i allt från listorna
            updateListView();

        }

        private void updateListView()
        {
            //Gör en kopia av listviewen i LedigaStugor (Exakt samma kod, annat namn på lvwBokaStuga)
            lvwBokaStuga.Items.Clear();
            string[] columnsStugor = new string[4];
            ListViewItem StugItem;
            for (int i = 0; i < cabinList.Count(); i++)
            {
                columnsStugor[0] = cabinList.Get(i).CabinID.ToString();
                columnsStugor[1] = cabinList.Get(i).CabinName;

                if (cabinList.Get(i).CabinAvailable == true) columnsStugor[2] = "Ledig";
                else columnsStugor[2] = "Ej ledig";

                columnsStugor[3] = cabinList.Get(i).CabinFreeFrom.ToString();
                StugItem = new ListViewItem(columnsStugor);
                lvwBokaStuga.Items.Add(StugItem);
            }

            for (int i = 0; i < columnsStugor.Length; i++)
            { lvwBokaStuga.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize); }

            //Gör en kopia av listviewen i AddCustomer (Exakt samma kod, annat namn på lvwBokaKund)

            lvwBokaKund.Items.Clear();
            string[] columns = new string[4];
            ListViewItem KundItem;
            for (int i = 0; i < customerList.Count(); i++)
            {
                columns[0] = customerList.Get(i).Förnamn;
                columns[1] = customerList.Get(i).Efternamn;
                columns[2] = customerList.Get(i).Adress;
                columns[3] = customerList.Get(i).Telefonnummer;
                KundItem = new ListViewItem(columns);
                lvwBokaKund.Items.Add(KundItem);
            }
            for (int i = 0; i < columns.Length; i++)
            { lvwBokaKund.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize); }

            
        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            int index = lvwBokaStuga.SelectedItems[0].Index;
            if (cabinList.Get(index).CabinAvailable == true) 
            {
                
                cabinList.Get(index).CabinAvailable = false;
                cabinList.Get(index).CabinFreeFrom = dtpLeaving.Value;
                updateListView();
                
                
            }
            
            
        }
    }
}
