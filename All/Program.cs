using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace All
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq70();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq70
        /// </summary>
        public static void Linq70()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numbers.All(n => n % 2 == 1);

            Console.WriteLine("The list contains only odd numbers: {0}" , onlyOdd);
        }

        /// <summary>
        /// Linq72
        /// </summary>
        public static void Linq72()
        {
            List<Product> products = Product.GetProductList();

            var productGroups =
                from p in products
                group p by p.Category into g
                where g.All(p => p.UnitsInStock > 0)
                select new { Category = g.Key, Products = g };

            ObjectDumper.Write(productGroups, 1);
        }
    }
}
