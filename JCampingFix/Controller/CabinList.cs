using JavaCamping.Model;
using JavaCamping.Service;
using JavaCamping.BinarySerialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCamping.Controller
{
    class CabinList
    {
        private List<Cabin> cabins;
        public CabinList()
        {
            cabins = new List<Cabin>();
            try
            {
                if (File.Exists("CabinLista.DAT"))
                {
                    cabins = BinarySerialization<List<Cabin>>.BinaryDeSerialize("CabinLista.DAT");
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

        public void Add(Cabin cabin)
        {
            cabins.Add(cabin);
        }

        public void Remove(Cabin cabin)
        {
            cabins.Remove(cabin);
        }

        public int Count()
        {
            return cabins.Count();
        }

        public Cabin Get(int index)
        {
            return cabins.ElementAt(index);
        }
        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Cabin>>.FileName = "CabinLista.DAT";
                BinarySerialization<List<Cabin>>.BinarySerialize(cabins);
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }

        public Cabin Find(string strFind)
        {
            var me = (from cabin in cabins
                      where cabin.CabinID.ToString() == strFind
                      select cabin).First();
            return me;
        }

        
    }
}
