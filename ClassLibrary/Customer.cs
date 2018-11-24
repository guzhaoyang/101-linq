using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer
    {
        public string Region { get; set; }

        public int CustomerID { get; set; }

        public string CompanyName { get; set; }

        public List<Order> Orders { get; set; }

        public static List<Customer> GetCustomerList()
        {
            return new List<Customer>();
        }
    }
}
