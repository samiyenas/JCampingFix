using JavaCamping.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCamping.Service
{
    class ServiceProvider
    {
        static CustomerList _customerService;
        static CabinList _cabinService;



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
    }
}
