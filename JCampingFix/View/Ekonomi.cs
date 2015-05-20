using JCampingFix.Model;
using JCampingFix.Service;
using JCampingFix.Controller;
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

    public partial class Ekonomi : Form
    {
        BookingList bookingList;
        CustomerList customerList;
        CabinList cabinList;
        PriceList priceList;
        public Ekonomi()
        {
            InitializeComponent();

            //Hämtar bookinglisten via serviceprovidern. Serviceprovidern hämtar via den sparade bookingfilen. Kan skapa errors, därför en trysats.
            try
            {
                bookingList = ServiceProvider.GetBookingService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Hämtar customerlisten via serviceprovidern. Serviceprovidern hämtar via den sparade customerfilen. Kan skapa errors, därför en trysats.
            try
            {
                customerList = ServiceProvider.GetCustomerService();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //Hämtar cabinlisten via serviceprovidern. Serviceprovidern hämtar via den sparade cabinfilen. Kan skapa errors, därför en trysats.
            try
            {
                cabinList = ServiceProvider.GetCabinService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //tbxHusvagnPris.Text = priceList.Get(1).ToString();
            //tbxStugpris.Text = priceList.Get(2).ToString();
            //tbxKWHpris.Text = priceList.Get(3).ToString();

            try
            {
                priceList = ServiceProvider.GetPriceService();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 

            initListView();
        }

        private void initListView()
        {
            lvwBokningar.FullRowSelect = true;
            lvwBokningar.GridLines = true;
            lvwBokningar.Columns.Add("BokningsID", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Kundens namn", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Stugans namn", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Arrival Date ", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Departure Date", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Betald", -2, HorizontalAlignment.Left);
            updateBookingListView();

        }

        private void updateBookingListView()
        {
            lvwBokningar.Items.Clear();
            string[] columnsBokningar = new string[6];
            ListViewItem BokningsItem;

            for (int i = 0; i < bookingList.Count(); i++)
            {
                //BokningsID
                columnsBokningar[0] = bookingList.Get(i).BookingID.ToString();

                //För och efternamn på kunden hämtas via ett ID hämtat från bokningslistan. Måste vara -1 pga array börjar på 0 medans ID börjar på 1(ID börja på 0? Fult =P)
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

        private void btnBetala_Click(object sender, EventArgs e)
        {
            int index = lvwBokningar.SelectedItems[0].Index;



            int kwh = 0;
            DateTime depDate = bookingList.Get(index).DepartureDate.Date;
            DateTime arrDate = bookingList.Get(index).ArrivalDate.Date;
            TimeSpan tot = depDate - arrDate;
            lblHusvagn.Text = kwh.ToString();
            uint hej = (((uint)tot.TotalDays + 1) * 4);
            lblKWH.Text = hej.ToString();

            //Om cabinID = 1000 så har en husvagn använts
            if (bookingList.Get(index).CabinID == 1000)
            {
                int totPris = (((int)tot.TotalDays + 1) * 4) + (kwh * 5);
                lblKWH.Text = totPris.ToString();
            }
            else
            {
                int totPris = (((int)tot.TotalDays + 1) * 10) + (kwh * 5);
                lblKWH.Text = totPris.ToString() + " Varav för dagar:" + ((tot.TotalDays + 1) * 10).ToString() + " Varav för elektricitet:" + (kwh * 5).ToString();
            }

        }

        private void btnPris_Click(object sender, EventArgs e)
        {
            int index = lvwBokningar.SelectedItems[0].Index;

            //Räknar ut hur länge som kunden stannat
            DateTime depDate = bookingList.Get(index).DepartureDate.Date;
            DateTime arrDate = bookingList.Get(index).ArrivalDate.Date;
            TimeSpan tot = depDate - arrDate;
            //Genom att casta till int så får vi i hela dagar, samt räknar ej med startdagen så måste addera ett.
            int hej = (((int)tot.TotalDays + 1) * 4);
        }

        private int kwhGenerator()
        {
            Random random = new Random();
            return random.Next(2000, 4000);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            priceList.Get(1).TrailerPrice = Convert.ToInt32(tbxHusvagnPris.Text);
            priceList.Get(1).CabinPrice = Convert.ToInt32(tbxStugpris.Text);
            priceList.Get(1).KwhPrice = Convert.ToInt32(tbxKWHpris.Text);
        }

        private void brnaddPrices_Click(object sender, EventArgs e)
        {
            try
            {
                priceList.Add(new Prices(Convert.ToInt32(tbxStugpris.Text), Convert.ToInt32(tbxHusvagnPris.Text), Convert.ToInt32(tbxKWHpris.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbxPrisLista.Text = "1 Natt i Stuga:        " + priceList.Get(0).CabinPrice + Environment.NewLine +
                                "1 Natt i Husvagn:   " + priceList.Get(0).TrailerPrice + Environment.NewLine +
                                "1 kWh:                   " + priceList.Get(0).KwhPrice;
        }

    }
}
