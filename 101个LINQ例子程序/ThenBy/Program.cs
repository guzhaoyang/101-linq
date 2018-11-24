using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ThenBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq38();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq35
        /// </summary>
        public static void Linq35()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedDigits = from d in digits
                               orderby d.Length, d
                               select d;
            Console.WriteLine("Sorted digits:");
            foreach (var d in sortedDigits)
            {
                Console.WriteLine(d);
            }
        }

        /// <summary>
        /// Linq36
        /// </summary>
        public static void Linq36()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords =
                words.OrderBy(a => a.Length)
                .ThenBy(a => a, new CaseInsensitiveComparer());
            ObjectDumper.Write(sortedWords);
        }

        /// <summary>
        /// Linq37
        /// </summary>
        public static void Linq37()
        {
            List<Product> products = GetProductList();
            var sortedProducts = from p in products
                                 orderby p.Category, p.UnitPrice descending
                                 select p;
            ObjectDumper.Write(sortedProducts);
        }

        public static void Linq38()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords =
                words.OrderBy(a => a.Length)
                .ThenByDescending(a => a, new CaseInsensitiveComparer());
            ObjectDumper.Write(sortedWords);
        }

        public static List<Product> GetProductList()
        {
            return new List<Product>();
        }

        public static List<Customer> GetCustomerList()
        {
            return new List<Customer>();
        }
    }
}
