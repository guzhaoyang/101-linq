using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq63();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq58
        /// </summary>
        public static void Linq58()
        {
            List<Product> products = Product.GetProductList();

            Product product12 = (
                from p in products
                where p.ProductID == 12
                select p)
                .First();

            ObjectDumper.Write(product12);
        }

        /// <summary>
        /// Linq59
        /// </summary>
        public static void Linq59()
        {
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string startsWithO = strings.First(s => s[0] == 'o');

            Console.WriteLine("A string starting with 'o': {0}", startsWithO);
        }

        /// <summary>
        /// Linq61
        /// </summary>
        public static void Linq61()
        {
            int[] numbers = { };

            int firstNumOrDefault = numbers.FirstOrDefault();

            Console.WriteLine(firstNumOrDefault);
        }

        /// <summary>
        /// Linq62
        /// </summary>
        public static void Linq62()
        {
            List<Product> products = Product.GetProductList();

            Product product789 = products.FirstOrDefault(p => p.ProductID == 789);

            Console.WriteLine("Product 789 exists: {0}", product789 != null);
        }

        /// <summary>
        /// Linq63
        /// </summary>
        public static void Linq63()
        {
            double?[] doubles = { 1.7, 2.3, 4.1, 1.9, 2.9 };

            double? num = doubles.FirstOrDefault((n) => (n >= 2));

            if(num != null)
            {
                Console.WriteLine("The value {0} is within 0.5 of its index position.", num);
            }
            else
            {
                Console.WriteLine("There is no number within 0.5 of its index position.");
            }
        }

        /// <summary>
        /// Linq64
        /// </summary>
        public static void Linq64()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int fourthLowNum = (
                from n in numbers
                where n > 5
                select n)
                .ElementAt(1);  // second number is index 1 because sequences use 0-based indexing

            Console.WriteLine("Second number > 5: {0}", fourthLowNum);
        }
    }
}
