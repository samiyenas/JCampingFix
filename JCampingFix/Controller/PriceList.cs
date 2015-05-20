using JCampingFix.BinarySerialization;
using JCampingFix.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCampingFix.Controller
{
    class PriceList
    {
        private List<Prices> prices;

        public PriceList()
        {
            prices = new List<Prices>();
            try
            {
                if (File.Exists("PriceLista.DAT"))
                {
                    prices = BinarySerialization<List<Prices>>.BinaryDeSerialize("PriceLista.DAT");
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

        public void Add(Prices price)
        {
            prices.Add(price);
        }

        public void Remove(Prices price)
        {
            prices.Remove(price);
        }
        public void RemoveAt(int index)
        {
            prices.RemoveAt(index);
        }
        public int Count()
        {
            return prices.Count();
        }

        public Prices Get(int index)
        {
            return prices.ElementAt(index);
        }
        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Prices>>.FileName = "PrizeLista.DAT";
                BinarySerialization<List<Prices>>.BinarySerialize(prices);
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }
    }
}
