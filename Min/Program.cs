using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Min
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq82();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq81
        /// </summary>
        public static void Linq81()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int minNum = numbers.Min();

            Console.WriteLine("The minimum number is {0}.", minNum);
        }

        /// <summary>
        /// Linq82
        /// </summary>
        public static void Linq82()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int shortestWord = words.Min(w => w.Length);

            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
        }

        /// <summary>
        /// Linq83
        /// </summary>
        public static void Linq83()
        {
            List<Product> products = Product.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) };

            ObjectDumper.Write(categories);
        }

        /// <summary>
        /// Linq84
        /// </summary>
        public static void Linq84()
        {
            List<Product> products = Product.GetProductList();

            var categories =
                from p in products
                group p by p.Category into g
                let minPrice = g.Min(p => p.UnitPrice)  //不知道let是什么含义
                //http://blog.csdn.net/jingmeifeng/article/details/7843728 let博客
                //http://www.cnblogs.com/chenxizhang/archive/2009/04/29/1446017.html let博客
                select new { Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == minPrice) };

            ObjectDumper.Write(categories, 1);
        }
    }
}
