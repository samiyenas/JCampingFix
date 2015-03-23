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
    public partial class AddCustomer : Form
    {
        CustomerList customerList;
        public AddCustomer()
        {
            InitializeComponent();
            try
            {
                customerList = ServiceProvider.GetCustomerService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            initListView();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer(tbxFörnamn.Text, tbxEfternamn.Text, tbxAdress.Text, tbxTelefonnummer.Text);
            customerList.Add(newCustomer);
            updateListView();

        }
        private void initListView()
        {

            lvwCustomer.FullRowSelect = true;
            lvwCustomer.GridLines = true;
            // Add Columns
            lvwCustomer.Columns.Add("Förnamn", -2, HorizontalAlignment.Left);
            lvwCustomer.Columns.Add("Efternamn", -2, HorizontalAlignment.Left);
            lvwCustomer.Columns.Add("Adress ", -2, HorizontalAlignment.Left);
            lvwCustomer.Columns.Add("Telefonnummer", -2, HorizontalAlignment.Left);


            updateListView();

        }

        private void updateListView()
        {
            lvwCustomer.Items.Clear();
            string[] columns = new string[4];
            ListViewItem item;
            for (int i = 0; i < customerList.Count(); i++)
            {
                columns[0] = customerList.Get(i).Förnamn;
                columns[1] = customerList.Get(i).Efternamn;
                columns[2] = customerList.Get(i).Adress;
                columns[3] = customerList.Get(i).Telefonnummer;
                item = new ListViewItem(columns);
                lvwCustomer.Items.Add(item);
            }
            for (int i = 0; i < columns.Length; i++)
            {

                lvwCustomer.AutoResizeColumn(i,
              ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }

        private void btnDeleteCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvwCustomer.SelectedItems[0].Index;

                customerList.RemoveAt(index);
                updateListView();
            }
            catch (Exception)
            {

                MessageBox.Show("Error!");
            }

        }


    }
}