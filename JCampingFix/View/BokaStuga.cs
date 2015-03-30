﻿using JCampingFix.Controller;
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
        BookingList bookingList;
        public BokaStuga()
        {

            InitializeComponent();
            cabinList = ServiceProvider.GetCabinService();
            customerList = ServiceProvider.GetCustomerService();
            //bookingList = ServiceProvider.GetBookingService();
            initListView();
            lvwBokaKund.HideSelection = false;
            lvwBokaStuga.HideSelection = false;
        }

        private void initListView()
        {
            //Initializar listviewen för stugorna, fixar alla kolumner
            lvwBokaStuga.FullRowSelect = true;
            lvwBokaStuga.GridLines = true;
            lvwBokaStuga.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwBokaStuga.Columns.Add("Stugnamn", -2, HorizontalAlignment.Left);
            lvwBokaStuga.Columns.Add("Ledig", -2, HorizontalAlignment.Left);
            lvwBokaStuga.Columns.Add("Ledig från", -2, HorizontalAlignment.Left);

            //Initializar listviewen för kunderna, fixar alla kolumner
            lvwBokaKund.FullRowSelect = true;
            lvwBokaKund.GridLines = true;
            lvwBokaKund.Columns.Add("Förnamn", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Efternamn", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Adress ", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Telefonnummer", -2, HorizontalAlignment.Left);

            //Initializar listviewen för alla bokningar, fixar alla kolumner
            lvwBokningar.FullRowSelect = true;
            lvwBokningar.GridLines = true;
            lvwBokningar.Columns.Add("BokningsID", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Kundens Namn", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Stugans namn", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Arrival Date ", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Departure Date", -2, HorizontalAlignment.Left);

            //Kallar på en update för att fylla i allt från listorna
            updateCabinListView();
            updateCustomerListView();
            updateBookingListView();

        }

        private void updateCabinListView()
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
        }

        private void updateBookingListView()
        {
            //ENABLA ALLT DETTA NÄR BOOKINGLISTEN EXISTERAR
        //    //Gör en update till listviewen lvwBokningar
        //    //lvwBokningar.Items.Clear();
        //    string[] columnsBokningar = new string[5];
        //    ListViewItem BokningsItem;

        //    for (int i = 0; i < bookingList.Count(); i++)
        //    {
        //        columnsBokningar[0] = bookingList.Get(i).BookingID.ToString();
        //        columnsBokningar[1] = bookingList.Get(i).CabinID.ToString();
        //        columnsBokningar[2] = bookingList.Get(i).CustomerID.ToString();
        //        columnsBokningar[3] = bookingList.Get(i).ArrivalDate.ToString();
        //        columnsBokningar[4] = bookingList.Get(i).DepartureDate.ToString();

        //        BokningsItem = new ListViewItem(columnsBokningar);
        //        lvwBokningar.Items.Add(BokningsItem);
        //    }

        //    for (int i = 0; i < columnsBokningar.Length; i++)
        //    {
        //        lvwBokaStuga.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
        //    }
        }

        private void updateCustomerListView()
        {
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


        private void lvwBokaKund_SelectedIndexChanged_UsingItems(object sender, System.EventArgs e)
        {
            int customerSelectedIndex = lvwBokaKund.SelectedItems[0].Index;
            tbxKund.Text = customerSelectedIndex.ToString();
        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            int index = lvwBokaStuga.SelectedItems[0].Index;
            if (cabinList.Get(index).CabinAvailable == true)
            {

                cabinList.Get(index).CabinAvailable = false;
                cabinList.Get(index).CabinFreeFrom = dtpLeaving.Value;
                updateCabinListView();
                updateCustomerListView();
                updateBookingListView();
                // Booking booking = new Booking((bookingList.Count() + 1).ToString(),  )




            }


        }
    }
}
