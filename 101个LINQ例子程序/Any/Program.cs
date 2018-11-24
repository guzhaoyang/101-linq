using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Any
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq67();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq67
        /// </summary>
        public static void Linq67()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));

            Console.WriteLine("There is a word that contains in the list that contains 'ei': {0}", iAfterE);
        }

        /// <summary>
        /// Linq69
        /// </summary>
        public static void Linq69()
        {
            List<Product> products = Product.GetProductList();

            var productGroups =
                from p in products
                group p by p.Category into g
                where g.Any(p => p.UnitsInStock == 0)
                select new { Category = g.Key, Products = g };

            ObjectDumper.Write(productGroups, 1);
        }
    }
}
