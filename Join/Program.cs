using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Linq102
        /// </summary>
        public static void Linq102()
        {
            string[] categories = new string[]{
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood" };

            List<Product> products = Product.GetProductList();

            var q =
                from c in categories
                join p in products on c equals p.Category
                select new { Category = c, p.ProductName };

            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + ":" + v.Category);
            }
        }

        /// <summary>
        /// Linq103
        /// </summary>
        public static void Linq103()
        {
            string[] categories = new string[]{
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood" };

            List<Product> products = Product.GetProductList();

            var q =
                from c in categories
                join p in products on c equals p.Category into ps
                select new { Category = c, Products = ps };

            foreach (var v in q)
            {
                Console.WriteLine(v.Category + ":");
                foreach (var p in v.Products)
                {
                    Console.WriteLine("    " + p.ProductName);
                }
            }
        }

        /// <summary>
        /// Linq104
        /// </summary>
        public static void Linq104()
        {
            string[] categories = new string[]{
                    "Beverages",
                    "Condiments",
                    "Vegetables",
                    "Dairy Products",
                    "Seafood" };

            List<Product> products = Product.GetProductList();

            var q =
                from c in categories
                join p in products on c equals p.Category into ps
                from p in ps
                select new { Category = c, p.ProductName };

            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + "    " + v.Category);
            }
        }

        public static void Linq105()
        {
            string[] categories = new string[]{
                    "Beverages",
                    "Condiments",
                    "Vegetables",
                    "Dairy Products",
                    "Seafood" };

            List<Product> products = Product.GetProductList();

            var q =
                from c in categories
                join p in products on c equals p.Category into ps
                from p in ps.DefaultIfEmpty()
                select new { Category = c, ProductName = p.ProductName == null ? "(No products)" : p.ProductName};

            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + " : " + v.Category);
            }
        }
    }
}
