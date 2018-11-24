using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Skip
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq22();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq22
        /// </summary>
        public static void Linq22()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var allButFirst4Numbers = numbers.Skip(4);//跳过前4个元素，返回剩下的元素
            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Linq23()
        {
            List<Customer> customers = GetCustomerList();
            var waOrders = from c in customers
                           from o in c.Orders
                           where c.Region == "WA"
                           select new { c.CustomerID, o.OrderID, o.OrderDate };
            var allButFirst2Orders = waOrders.Skip(2);
            Console.WriteLine("All but first 2 orders in WA:");
            foreach (var order in allButFirst2Orders)
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
