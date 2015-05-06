using JCampingFix.Model;
using JCampingFix.Service;
using JCampingFix.BinarySerialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCampingFix.Controller
{
    class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
            try
            {
                if (File.Exists("MemberLista.DAT"))
                {
                    customers = BinarySerialization<List<Customer>>.BinaryDeSerialize("MemberLista.DAT");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }
        public void RemoveAt(int index)
        {
            customers.RemoveAt(index);
        }
        public int Count()
        {
            return customers.Count();
        }

        public Customer Get(int index)
        {
            return customers.ElementAt(index);
        }
        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Customer>>.FileName = "MemberLista.DAT";
                BinarySerialization<List<Customer>>.BinarySerialize(customers);
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }

        public Customer Find(string strFind)
        {
            var me = (from customer in customers
                      where customer.CustomerID.ToString() == strFind
                      select customer).First();
            return me;
        }
   
       
    }
}
