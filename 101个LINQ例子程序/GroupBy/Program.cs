using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq45();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq40
        /// </summary>
        public static void Linq40()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numberGroups =
                from n in numbers
                group n by n % 5 into g
                select new { Remainder = g.Key, Numbers = g };
            foreach (var g in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);
                foreach (var n in g.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }

        /// <summary>
        /// Linq41
        /// </summary>
        public static void Linq41()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            var wordGroups =
                from w in words
                group w by w[0] into g
                select new { FirstLetter = g.Key, Words = g };
            foreach (var g in wordGroups)
            {
                Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
                foreach (var w in g.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }

        /// <summary>
        /// Linq42
        /// </summary>
        public void Linq42()
        {
            List<Product> products = Product.GetProductList();
            var orderGroups =
                from p in products
                group p by p.Category into g
                select new { Category = g.Key, Products = g };
            ObjectDumper.Write(orderGroups, 1);
        }

        /// <summary>
        /// Linq43  这个复杂些，需要慢慢领悟
        /// </summary>
        public void Linq43()
        {
            List<Customer> customers = Customer.GetCustomerList();
            var customerOrderGroups =
                from c in customers
                select new
                {
                    c.CompanyName,
                    YearGroups =
                    from o in c.Orders
                    group o by o.OrderDate.Year into yg//按年份分组
                    select new
                    {
                        Year = yg.Key,
                        MonthGroups =
                        from o in yg
                        group o by o.OrderDate.Month into mg//按月份分组
                        select new
                        {
                            Month = mg.Key,
                            Orders = mg
                        }
                    }
                };
            ObjectDumper.Write(customerOrderGroups, 3);
        }

        /// <summary>
        /// Linq44
        /// </summary>
        public static void Linq44()
        {
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            var orderGroups = anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());
            ObjectDumper.Write(orderGroups, 1);
        }

        public static void Linq45()
        {
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            var orderGroups = anagrams.GroupBy(w => w.Trim(), a => a.ToUpper(), new AnagramEqualityComparer());
            ObjectDumper.Write(orderGroups, 1);
        }
    }
}
