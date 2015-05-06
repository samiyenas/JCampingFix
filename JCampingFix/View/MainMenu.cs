using JCampingFix.View;
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
using System.IO;

namespace JCampingFix.View
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Skapar en ny instans av AddCustomer och visar den, nytt fönster poppar upp
        private void läggTillKundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer f = new AddCustomer();
            f.Show();
        }

        //Sparar memberlista.dat med hjälp av en messagebox
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("MemberLista.DAT"))
                {
                    if (AskAQuestion("MemberLista.DAT File exist.\nAre you sure you want to replace it?"))
                        ServiceProvider.GetCustomerService().BinarySerialize();
                }
                else
                {
                    ServiceProvider.GetCustomerService().BinarySerialize();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Här kan vi ställa en fråga och få ett boolsvar via en messagebox
        private bool AskAQuestion(string question)
        {
            DialogResult dialogResult = MessageBox.Show(question, "Important", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Skapar och visar en ny instans av lediga stugor, nytt fönster poppar upp
        private void ledigaStugorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LedigaStugor f = new LedigaStugor();
            f.Show();
        }

        //Samma som tidigare sparinstansen, men bytte ut memberlista mot cabinlista
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("CabinLista.DAT"))
                {
                    if (AskAQuestion("CabinLista.DAT File exist.\nAre you sure you want to replace it?"))
                        ServiceProvider.GetCabinService().BinarySerialize();
                }

            }
            catch (Exception)
            {
                ServiceProvider.GetCabinService().BinarySerialize();
            }

        }

        private void bokaEnStugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BokaStuga f = new BokaStuga();
            f.Show();
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            try
            {
                if (File.Exists("BookingLista.DAT"))
                {
                    if (AskAQuestion("BookingLista.DAT File exist.\nAre you sure you want to replace it?"))
                        ServiceProvider.GetBookingService().BinarySerialize();
                        ServiceProvider.GetCabinService().BinarySerialize();
                        ServiceProvider.GetCustomerService().BinarySerialize();
                }

            }
            catch (Exception)
            {
                ServiceProvider.GetBookingService().BinarySerialize();
            }
        }

       

        private void bokningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekonomi f = new Ekonomi();
            f.Show();
        }

        private void saveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("PriceLista.DAT"))
                {
                    if (AskAQuestion("PriceLista.DAT File exist.\nAre you sure you want to replace it?"))
                        ServiceProvider.GetBookingService().BinarySerialize();
                    ServiceProvider.GetCabinService().BinarySerialize();
                    ServiceProvider.GetCustomerService().BinarySerialize();
                    ServiceProvider.GetPriceService().BinarySerialize();
                }

            }
            catch (Exception)
            {
                ServiceProvider.GetPriceService().BinarySerialize();
            }
        }


    }
}
