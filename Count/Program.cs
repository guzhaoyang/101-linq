using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq74();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq73
        /// </summary>
        public static void Linq73()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique factors of 300.", uniqueFactors);
        }

        /// <summary>
        /// Linq74
        /// </summary>
        public static void Linq74()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }

        /// <summary>
        /// Linq76
        /// </summary>
        public static void Linq76()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orderCounts =
                from c in customers
                select new { c.CustomerID, OrderCounts = c.Orders.Count() };

            ObjectDumper.Write(orderCounts);
        }

        /// <summary>
        /// Linq77
        /// </summary>
        public static void Linq77()
        {
            List<Product> products = Product.GetProductList();

            var categoryCounts =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, ProductCount = g.Count() };

            ObjectDumper.Write(categoryCounts);
        }
    }
}
