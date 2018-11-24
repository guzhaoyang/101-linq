using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq86();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq85
        /// </summary>
        public static void Linq85()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int maxNum = numbers.Max();

            Console.WriteLine("The maximum number is {0}.", maxNum);
        }

        /// <summary>
        /// Linq86
        /// </summary>
        public static void Linq86()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int longestLength = words.Max(w => w.Length);

            Console.WriteLine("The longest word is {0} characters long.", longestLength);
        }

        /// <summary>
        /// Linq87
        /// </summary>
        public static void Linq87()
        {
            List<Product> products = Product.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) };

            ObjectDumper.Write(categories);
        }

        /// <summary>
        /// Linq88
        /// </summary>
        public static void Linq88()
        {
            List<Product> products = Product.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                let maxPrice = g.Max(p => p.UnitPrice)
                select new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == maxPrice) };

            ObjectDumper.Write(categories, 1);
        }
    }
}
