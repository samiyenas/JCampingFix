using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCamping.Model
{
    [Serializable]
    class Cabin
    {
        //Stugans ID, get set
        private int cabinID;
        public int CabinID
        {
            get { return cabinID; }
            set { cabinID = value; }
        }

        //Stugans Namn, get set
        private string cabinName;

        public string CabinName
        {
            get { return cabinName; }
            set { cabinName = value; }
        }

        //Om stugan är ledig, get set
        private bool cabinAvailable;

        public bool CabinAvailable
        {
            get { return cabinAvailable; }
            set { cabinAvailable = value; }
        }

        //Samt en konstruktor
        public Cabin(int CabinID, string CabinName, bool CabinAvailable)
        {
            this.cabinID = CabinID;
            this.cabinName = CabinName;
            this.cabinAvailable = CabinAvailable;
            
        }
    }
}
