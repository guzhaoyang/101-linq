using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace TakeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq25();
            Console.ReadKey();
        }

        /*******************************
         *TakeWhile()方法 从集合开头根据条件判断元素，如果条件为false,则不进行对后面元素的判断。
         ******************************/

        /// <summary>
        /// Linq24
        /// </summary>
        public static void Linq24()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
            Console.WriteLine("First numbers less than 6:");
            foreach (var n in firstNumbersLessThan6)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Linq25
        /// </summary>
        public static void Linq25()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
            Console.WriteLine("First numbers not less than their position");
            foreach (var n in firstSmallNumbers)
            {
                Console.WriteLine(n);
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
