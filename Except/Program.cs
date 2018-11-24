using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Except
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq52();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq52
        /// </summary>
        public static void Linq52()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);

            Console.WriteLine("Numbers in first array but not second array:");
            foreach (var n in aOnlyNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Linq53()
        {
            List<Product> products = Product.GetProductList();
            List<Customer> customers = Customer.GetCustomerList();

            var productFirstChars =
                from p in products
                select p.ProductName[0];
            var customerFirstChars =
                from c in customers
                select c.CompanyName[0];

            var productOnlyFirstChars = productFirstChars.Except(customerFirstChars);

            Console.WriteLine("First letters from Product names, but not from Customer names:");
            foreach (var ch in productOnlyFirstChars)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
