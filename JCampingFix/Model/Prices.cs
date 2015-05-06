using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCampingFix.Model
{
    [Serializable]
    class Prices
    {
        //Stugans ID, get set
        private int cabinPrice;
        public int CabinPrice
        {
            get { return cabinPrice; }
            set { cabinPrice = value; }
        }

        //Stugans ID, get set
        private int trailerPrice;
        public int TrailerPrice
        {
            get { return trailerPrice; }
            set { trailerPrice= value; }
        }

        //Stugans ID, get set
        private int kwhPrice;
        public int KwhPrice
        {
            get { return kwhPrice; }
            set { kwhPrice = value; }
        }

        
        public Prices(int CabinPrice, int TrailerPrice, int KwhPrice)
        {
            this.cabinPrice = CabinPrice;
            this.trailerPrice = TrailerPrice;
            this.kwhPrice = KwhPrice;
        }

    }
}
