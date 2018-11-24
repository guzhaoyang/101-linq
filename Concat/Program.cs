using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq95();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq94
        /// </summary>
        public static void Linq94()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var allNumbers = numbersA.Concat(numbersB);

            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Linq95
        /// </summary>
        public static void Linq95()
        {
            List<Product> products = Product.GetProductList();
            List<Customer> customers = Customer.GetCustomerList();

            var customerNames =
                from c in customers
                select c.CompanyName;
            var productNames =
                from p in products
                select p.ProductName;

            var allNames = customerNames.Concat(productNames);

            Console.WriteLine("Customer and product names:");
            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
        }
    }
}
