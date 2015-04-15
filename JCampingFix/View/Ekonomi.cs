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
        BookingList bookinglist;
        
        public Ekonomi()
        {
            InitializeComponent();
            try
            {
                bookinglist = ServiceProvider.GetBookingService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        }



        
    }
}
