using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq79();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq78
        /// </summary>
        public static void Linq78()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double numSum = numbers.Sum();

            Console.WriteLine("The sum of the numbers is {0}.", numSum);
        }

        /// <summary>
        /// Linq79
        /// </summary>
        public static void Linq79()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double totalChars = words.Sum(n => n.Length);

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }

        public static void Linq80()
        {
            List<Product> products = Product.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) };

            ObjectDumper.Write(categories);
        }
    }
}
