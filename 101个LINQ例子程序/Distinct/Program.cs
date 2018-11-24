using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq46();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq46
        /// </summary>
        public static void Linq46()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            var uniqueFactors = factorsOf300.Distinct();
            Console.WriteLine("Prime factors of 300:");
            foreach (var f in uniqueFactors)
            {
                Console.WriteLine(f);
            }
        }

        /// <summary>
        /// Linq47
        /// </summary>
        public static void Linq47()
        {
            List<Product> products = Product.GetProductList();
            var categoryNames = (
                from p in products
                select p.Category)
                .Distinct();

            Console.WriteLine("Category names:");
            foreach (var n in categoryNames)
            {
                Console.WriteLine(n);
            }
        }
    }
}
