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


        public void Add(Booking booking)
        {
            bookings.Add(booking);
        }

        public void Remove(Booking booking)
        {
            bookings.Remove(booking);
        }

        public int Count()
        {
            return bookings.Count();
        }

        public Booking Get(int index)
        {
            return bookings.ElementAt(index);
        }

        public Booking Find(string strFind)
        {
            var me = (from cabin in bookings
                      where cabin.CabinID.ToString() == strFind
                      select cabin).First();
            return me;
        }



        internal void RemoveAt(int index)
        {
            bookings.RemoveAt(index);

        }

    }
}
