using JCampingFix.BinarySerialization;
using JCampingFix.Model;
using JCampingFix.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCampingFix.Controller
{
    class BookingList
    {
        private List<Booking> bookings;
        public BookingList()
        {
            bookings = new List<Booking>();
            try
            {
                if (File.Exists("BookingLista.DAT"))
                {
                    bookings = BinarySerialization<List<Booking>>.BinaryDeSerialize("BookingLista.DAT");
                }
                else
                {
                    this.BinarySerialize();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Booking>>.FileName = "BookingLista.DAT";
                BinarySerialization<List<Booking>>.BinarySerialize(bookings);
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }
    }
}
