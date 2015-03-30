using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCampingFix.Model
{
    class Booking
    {

        private int bookingID;


        public int BookingID { get{return bookingID;} set{bookingID = value;} }

        private int cabinID;
        public int CabinID { get { return cabinID; } set { cabinID = value; } }

        private int customerID;
        public int CustomerID { get { return customerID; } set { customerID = value; } }

        private DateTime arrivalDate;
        public DateTime Arrivaldate { get { return arrivalDate; } set { arrivalDate = value; } }

        private DateTime departureDate;
        public DateTime DepartureDate { get { return departureDate; } set { departureDate = value; } }



    }
}
