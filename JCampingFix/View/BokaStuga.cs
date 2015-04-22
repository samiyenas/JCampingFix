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
        BookingList bookingList;
        public BokaStuga()
        {

            InitializeComponent();
            try
            {
                cabinList = ServiceProvider.GetCabinService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                customerList = ServiceProvider.GetCustomerService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                bookingList = ServiceProvider.GetBookingService();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            initListView();
            lvwBokaKund.HideSelection = false;
            lvwBokaStuga.HideSelection = false;
        }

        //Behövs inga separata initializers, ska bara köras en gång och inte separat
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
            lvwBokaKund.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Förnamn", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Efternamn", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Adress ", -2, HorizontalAlignment.Left);
            lvwBokaKund.Columns.Add("Telefonnummer", -2, HorizontalAlignment.Left);

            //Initializar listviewen för alla bokningar, fixar alla kolumner
            lvwBokningar.FullRowSelect = true;
            lvwBokningar.GridLines = true;
            lvwBokningar.Columns.Add("BokningsID", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Kundens namn", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Stugans namn", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Arrival Date ", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Departure Date", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Betald", -2, HorizontalAlignment.Left);

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
            //Gör en update till listviewen lvwBokningar
            lvwBokningar.Items.Clear();
            string[] columnsBokningar = new string[6];
            ListViewItem BokningsItem;

            for (int i = 0; i < bookingList.Count(); i++)
            {
                //BokningsID
                columnsBokningar[0] = bookingList.Get(i).BookingID.ToString();

                //För och efternamn på kunden hämtas via ett ID hämtat från bokningslistan. Måste vara -1 pga array börjar på 0 medans ID börjar på 1
                columnsBokningar[1] = customerList.Get(bookingList.Get(i).CustomerID - 1).Förnamn + " " + customerList.Get(bookingList.Get(i).CustomerID - 1).Efternamn;

                //Namn på stugan hämtas via ett id hämtat från bokningslistan om inte en husvagn används. ID 1000 används för att identifiera husvagnar.
                if (bookingList.Get(i).CabinID == 1000)
                {
                    columnsBokningar[2] = "Husvagn";
                }
                else
                {
                    columnsBokningar[2] = cabinList.Get(bookingList.Get(i).CabinID - 1).CabinName;
                }

                columnsBokningar[3] = bookingList.Get(i).ArrivalDate.ToString();
                columnsBokningar[4] = bookingList.Get(i).DepartureDate.ToString();
                columnsBokningar[5] = bookingList.Get(i).Paid.ToString();

                BokningsItem = new ListViewItem(columnsBokningar);
                lvwBokningar.Items.Add(BokningsItem);
            }

            for (int i = 0; i < columnsBokningar.Length; i++)
            { lvwBokningar.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize); }
        }

        private void updateCustomerListView()
        {
            //Gör en kopia av listviewen i AddCustomer (Exakt samma kod, annat namn på lvwBokaKund)

            lvwBokaKund.Items.Clear();
            string[] columns = new string[5];
            ListViewItem KundItem;
            for (int i = 0; i < customerList.Count(); i++)
            {
                columns[0] = customerList.Get(i).CustomerID.ToString();
                columns[1] = customerList.Get(i).Förnamn;
                columns[2] = customerList.Get(i).Efternamn;
                columns[3] = customerList.Get(i).Adress;
                columns[4] = customerList.Get(i).Telefonnummer;
                KundItem = new ListViewItem(columns);
                lvwBokaKund.Items.Add(KundItem);
            }
            for (int i = 0; i < columns.Length; i++)
            { lvwBokaKund.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize); }
        }


        private void lvwBokaKund_SelectedIndexChanged_UsingItems(object sender, System.EventArgs e)
        {
            int customerSelectedIndex = lvwBokaKund.SelectedItems[0].Index;
        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            try
            {
                // Kolla vad som är valt
                int cabinIndex = lvwBokaStuga.SelectedItems[0].Index;
                int customerIndex = lvwBokaKund.SelectedItems[0].Index;

                if (cabinList.Get(cabinIndex).CabinAvailable == true)
                {

                    cabinList.Get(cabinIndex).CabinAvailable = false;
                    cabinList.Get(cabinIndex).CabinFreeFrom = dtpLeaving.Value;

                    //Hämtar information för bokningen från cabinList och customerlist 
                    //genom att kolla på den valda raden. Bokningen är automatiskt inte betald.
                    int customerID = customerList.Get(customerIndex).CustomerID;
                    int cabinID = cabinList.Get(cabinIndex).CabinID;
                    int bookingID = bookingList.Count() + 1;

                    //Kolla om husvagn ska användas
                    //om den ska användas, använd värdet 1000 för att visa i listviewen att det är en husvagn
                    if (cbxHusvagn.Checked == true)
                    {
                        Booking booking = new Booking(bookingID, customerID, 1000, dtpArriving.Value, dtpLeaving.Value, false);
                        bookingList.Add(booking);
                    }
                    else
                    {
                        Booking booking = new Booking(bookingID, customerID, cabinID, dtpArriving.Value, dtpLeaving.Value, false);
                        bookingList.Add(booking);
                    }
                    
                    updateBookingListView();
                    updateCabinListView();
                    updateCustomerListView();

                }

                else
                {
                    MessageBox.Show("Stugan är ej ledig");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Välj en kund och en stuga");
                updateCabinListView();
            }



        }

        private void btnLedig_Click(object sender, EventArgs e)
        {
            int cabinIndex = lvwBokaStuga.SelectedItems[0].Index;
            cabinList.Get(cabinIndex).CabinAvailable = true;
            updateCabinListView();
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            int i = lvwBokningar.SelectedItems[0].Index;
            bookingList.RemoveAt(i);
            updateBookingListView();
        }
    }
}
