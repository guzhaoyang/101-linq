using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Take
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq20();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq20
        /// </summary>
        public static void Linq20()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var first3Numbers = numbers.Take(3);
            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Linq21
        /// </summary>
        public static void Linq21()
        {
            List<Customer> customers = GetCustomerList();
            var first3WAOrders = (
                from c in customers
                from o in c.Orders
                where c.Region == "WA"
                select new { c.CustomerID, o.OrderID, o.OrderDate })
                                 .Take(3);
            Console.WriteLine("First 3 orders in WA:");
            foreach (var order in first3WAOrders)
            {
                ObjectDumper.Write(order);
            }
        }

        public static List<Product> GetProductList()
        {
            return new List<Product>();
        }

        public static List<Customer> GetCustomerList()
        {
            return new List<Customer>();
        }
    }
}
