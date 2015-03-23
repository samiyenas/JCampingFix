using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCamping.Model
{
    [Serializable]
    class Customer
    {  
        
        

        private int customerID;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        
        private string förnamn;

        public string Förnamn
        {
            get { return förnamn; }
            set { förnamn = value; }
        }

        private string efternamn;

        public string Efternamn
        {
            get { return efternamn; }
            set { efternamn = value; }
        }

        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        private string telefonnummer;

        public string Telefonnummer
        {
            get { return telefonnummer; }
            set { telefonnummer = value; }
        }
        
       
        

        public Customer(string Förnamn, string Efternamn, string Adress, string Telefonnummer)
        {
            // TODO: Complete member initialization
            this.förnamn = Förnamn;
            this.efternamn = Efternamn;
            this.adress = Adress;
            this.telefonnummer = Telefonnummer;

        }

      
    }
}
