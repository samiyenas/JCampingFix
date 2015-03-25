using JCampingFix.Controller;
using JCampingFix.Model;
using JCampingFix.Service;
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
    public partial class LedigaStugor : Form
    {//Ser till att det inte krashar incase of tom list
        CabinList cabinlist = new CabinList();
        public LedigaStugor()
        {
            InitializeComponent();
            try
            {
                cabinlist = ServiceProvider.GetCabinService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            initListView();

        }

        //Skapar en ny ledig stuga, som är ledig
        private void btnLedigaStugor_Click(object sender, EventArgs e)
        {
            Cabin newCabin = new Cabin(Convert.ToInt32(cabinlist.Count() + 1), tbxStugNamn.Text, true);
            cabinlist.Add(newCabin);
            tbxStugNamn.Clear();
            updateListView();

        }
        //Initializar Listviewen
        private void initListView()
        {

            lvwCabin.FullRowSelect = true;
            lvwCabin.GridLines = true;
            // Lägger till alla kolumner
            lvwCabin.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwCabin.Columns.Add("Stugnamn", -2, HorizontalAlignment.Left);
            lvwCabin.Columns.Add("Ledig", -2, HorizontalAlignment.Left);

            updateListView();

        }
        //Uppdaterar listviewen med alla stugor.
        private void updateListView()
        {
            // Börjar med att cleara allt
            lvwCabin.Items.Clear();
            string[] columns = new string[3];
            ListViewItem item;
            //Lägg sedan till alla från listan med stugor, med alla deras properties (CabinID, CabinName och CabinAvailable)
            for (int i = 0; i < cabinlist.Count(); i++)
            {
                columns[0] = cabinlist.Get(i).CabinID.ToString();
                columns[1] = cabinlist.Get(i).CabinName;

                if (cabinlist.Get(i).CabinAvailable == true) columns[2] = "Ledig";
                else columns[2] = "Ej ledig";

                item = new ListViewItem(columns);
                lvwCabin.Items.Add(item);
            }

            //Rezizar så att all text syns.
            for (int i = 0; i < columns.Length; i++)
            {

                lvwCabin.AutoResizeColumn(i,
              ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }

        private void btnDeleteCabin_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvwCabin.SelectedItems[0].Index;

                cabinlist.RemoveAt(index);
                updateListView();
            }
            catch (Exception)
            {

                MessageBox.Show("Error!");
            }
        }
    }
}
