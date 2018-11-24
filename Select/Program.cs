/**************************************
 * 功能描述：linq之Where练习
 * 作者：古兆洋
 * 创建日期：2017-7-15
 * 修改日期：2017-7-15
 * ***********************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Diagnostics;

namespace Select
{
    class Program
    {
        static void Main(string[] args)
        {
            linq14();
            Console.ReadKey();
        }

        /// <summary>
        /// linq6
        /// </summary>
        public static void linq6()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numsPlusOne = from n in numbers
                              select n + 1;
            Console.WriteLine("Numbers + 1:");
            foreach (var item in numsPlusOne)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// linq7
        /// </summary>
        public static void linq7()
        {
            List<Product> products = GetProductList();
            var productNames = from p in products
                               select p.ProductName;
            Console.WriteLine("Product Names:");
            foreach (var productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }

        /// <summary>
        /// linq8
        /// </summary>
        public static void linq8()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var textNums = from n in numbers
                           select strings[n];
            Console.WriteLine("Number strings:");
            foreach (var item in textNums)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// linq9
        /// </summary>
        public static void linq9()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var upperLowerWords = from w in words
                                  select new { Upper = w.ToUpper(), Lower = w.ToLower() };
            foreach (var item in upperLowerWords)
            {
                Console.WriteLine("Uppercase: {0}, Lowercase: {1}",item.Upper,item.Lower);
            }
        }

        /// <summary>
        /// linq10
        /// </summary>
        public static void linq10()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digitOddEvens = from n in numbers
                                select new { digit = strings[n], Even = (n % 2 == 0) };
            foreach (var item in digitOddEvens)
            {
                Console.WriteLine("The digit {0} is {1}.",item.digit,item.Even?"even":"odd");
            }
        }

        /// <summary>
        /// linq11
        /// </summary>
        public static void linq11()
        {
            List<Product> product = GetProductList();
            var productInfos = from p in product
                               select new { p.ProductName, p.Category, Price = p.UnitPrice };
            Console.WriteLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                Console.WriteLine("{0} is in the category {1} and costs {2} per unit.",productInfo.ProductName,productInfo.Category,productInfo.Price);
            }
        }

        /// <summary>
        /// linq12
        /// </summary>
        public static void linq12()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });
            Console.WriteLine("Number: In-place?");
            foreach (var n in numsInPlace)
            {
                Console.WriteLine("{0}:{1}",n.Num,n.InPlace);
            }
        }

        /// <summary>
        /// linq13
        /// </summary>
        public static void linq13()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var lowNums = from n in numbers
                          where n < 5
                          select digits[n];
            Console.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// linq14
        /// </summary>
        public static void linq14()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select new { a, b };
            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}",pair.a,pair.b);
            }
        }

        /// <summary>
        /// linq15
        /// </summary>
        public static void linq15()
        {
            List<Customer> customers = GetCustomerList();
            var orders = from c in customers
                         from o in c.Orders
                         where o.Total < 500.00M
                         select new { c.CustomerID, o.OrderID, o.Total};
            ObjectDumper.Write(orders);
        }

        /// <summary>
        /// linq16
        /// </summary>
        public static void linq16()
        {
            List<Customer> customers = GetCustomerList();
            var orders = from c in customers
                         from o in c.Orders
                         where o.OrderDate >= new DateTime(1998, 1, 1)
                         select new { c.CustomerID, o.OrderID, o.OrderDate };
            ObjectDumper.Write(orders);
        }

        /// <summary>
        /// linq17
        /// </summary>
        public static void linq17()
        {
            List<Customer> customers = GetCustomerList();
            var orders = from c in customers
                         from o in c.Orders
                         where o.Total >= 2000.00M
                         select new { c.CustomerID, o.OrderID, o.Total };
            ObjectDumper.Write(orders);
        }

        /// <summary>
        /// linq18
        /// </summary>
        public static void linq18()
        {
            List<Customer> customers = GetCustomerList();
            DateTime cutoffDate = new DateTime(1997, 1, 1);
            var orders = from c in customers
                         where c.Region == "WA"
                         from o in c.Orders
                         where o.OrderDate >= cutoffDate
                         select new { c.CustomerID, o.OrderID };
            ObjectDumper.Write(orders);
        }

        public static void linq19()
        {
            List<Customer> customers = GetCustomerList();
            var customerOrders =
                customers.SelectMany(
                    (cust, custIndex) =>
                    cust.Orders.Select(o => "Customer #" + (custIndex + 1) + " has an order with OrderID " + o.OrderID));
            ObjectDumper.Write(customerOrders);
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
