using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq50();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq50
        /// </summary>
        public static void Linq50()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var commonNumbers = numbersA.Intersect(numbersB);

            Console.WriteLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Linq51
        /// </summary>
        public static void Linq51()
        {
            List<Product> products = Product.GetProductList();
            List<Customer> customers = Customer.GetCustomerList();

            var productFirstChars =
                from p in products
                select p.ProductName[0];
            var customerFirstChars =
                from c in customers
                select c.CompanyName[0];

            var commonFirstChars = productFirstChars.Intersect(customerFirstChars);

            Console.WriteLine("Common first letters from Product names and Customer names:");
            foreach (var ch in commonFirstChars)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
