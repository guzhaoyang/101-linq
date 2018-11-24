using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq34();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq28
        /// </summary>
        public static void Linq28()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from w in words
                              orderby w
                              select w;
            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
        }

        /// <summary>
        /// Linq29
        /// </summary>
        public static void Linq29()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from w in words
                              orderby w.Length
                              select w;
            Console.WriteLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
        }

        /// <summary>
        /// Linq30
        /// </summary>
        public static void Linq30()
        {
            List<Product> products = GetProductList();
            var sortedProducts = from p in products
                                 orderby p.ProductName
                                 select p;
            ObjectDumper.Write(sortedProducts);
        }

        /// <summary>
        /// Linq31
        /// </summary>
        public static void Linq31()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());
            ObjectDumper.Write(sortedWords);
        }

        /// <summary>
        /// Linq32
        /// </summary>
        public static void Linq32()
        {
            
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var sortedDoubles = 
                from d in doubles
                orderby d descending
                select d;

            Console.WriteLine("The doubles from highest to lowest:");
            foreach (var d in sortedDoubles)
            {
                Console.WriteLine(d);
            }
        }

        /// <summary>
        /// Linq33
        /// </summary>
        public static void Linq33()
        {
            List<Product> products = GetProductList();
            var sortedProducts = from p in products
                                 orderby p.UnitPrice descending
                                 select p;
            ObjectDumper.Write(sortedProducts);
        }

        /// <summary>
        /// Linq34
        /// </summary>
        public static void Linq34()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());
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
