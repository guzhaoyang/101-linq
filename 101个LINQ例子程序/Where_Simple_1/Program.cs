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

namespace Where_Simple_1
{
    class Program
    {
        static void Main(string[] args)
        {
            linq5();
            Console.ReadKey();
        }

        /// <summary>
        /// Simple
        /// </summary>
        /// gzy
        /// 2017-7-15
        public static void linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNumbers = from n in numbers
                             where n < 5
                             select n;
            Console.WriteLine("Numbers < 5");
            foreach (var item in lowNumbers)
            {
                Console.WriteLine(item);
            }
        }

        
        /// <summary>
        /// linq2
        /// </summary>
        public static void linq2()
        {
            //获取商品列表
            List<Product> products = GetProductList();
            var soldOutProducts = from p in products
                                  where p.UnitsInStock == 0
                                  select p;
            Console.WriteLine("Sold out products:");
            foreach (var item in soldOutProducts)
            {
                Console.WriteLine("{0} is sold out!", item.ProductName);
            }
        }

        /// <summary>
        /// linq3
        /// </summary>
        public static void linq3()
        {
            List<Product> products = GetProductList();
            var expensiveInStockProducts = from p in products
                                           where p.UnitsInStock > 0 && p.UnitPrice > 3.00M
                                           select p;
            Console.WriteLine("In - stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Console.WriteLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }
        }

        /// <summary>
        /// linq4
        /// </summary>
        public static void linq4()
        {
            //获取客户列表
            List<Customer> customers = GetCustomerList();
            var waCustomers = from c in customers
                              where c.Region == "WA"
                              select c;
            Console.WriteLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                //显示客户id和姓名
                Console.WriteLine("Customer {0}: {1}",customer.CustomerID,customer.CompanyName);
                //显示客户的订单信息
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("Order {0}: {1}",order.OrderID,order.OrderDate.ToString());
                }
            }
        }

        /// <summary>
        /// linq5
        /// </summary>
        public static void linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((digit, i) => digit.Length < i);//其中，index表示数组下标
            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.",d);
            }
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
