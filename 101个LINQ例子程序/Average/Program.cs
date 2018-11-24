using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq90();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq89
        /// </summary>
        public static void Linq89()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double averageNum = numbers.Average();

            Console.WriteLine("The average number is {0}.", averageNum);
        }

        /// <summary>
        /// Linq90
        /// </summary>
        public static void Linq90()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double averageLength = words.Average(w => w.Length);

            Console.WriteLine("The average word length is {0} characters.", averageLength);
        }

        /// <summary>
        /// Linq91
        /// </summary>
        public static void Linq91()
        {
            List<Product> products = Product.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) };

            ObjectDumper.Write(categories);
        }
    }
}
