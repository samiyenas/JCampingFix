using JCampingFix.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCampingFix.Service
{
    class ServiceProvider
    {
        static CustomerList _customerService;
        static CabinList _cabinService;
        static BookingList _bookingService;



        public static CustomerList GetCustomerService()
        {
            if (_customerService == null)
            {
                try
                {
                    _customerService = new CustomerList();
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
            }

            return _customerService;

            
        }

        public static CabinList GetCabinService()
        {
            if (_cabinService == null)
            {
                try
                {
                    _cabinService = new CabinList();
                }
                catch (Exception)
                {

                    throw;
                }

            }

            return _cabinService;


        }

        public static BookingList GetBookingService()
        {
            if (_bookingService == null)
            {
                try
                {
                    _bookingService = new BookingList();
                }
                catch (Exception)
                {

                    throw;
                }

            }

            return _bookingService;


        }
    }
}
