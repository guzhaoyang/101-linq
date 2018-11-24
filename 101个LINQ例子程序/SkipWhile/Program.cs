using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace SkipWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq27();
            Console.ReadKey();
        }

        /************************************
         * http://blog.csdn.net/lxfzgg/article/details/20534281 
         * *********************************/
        /// <summary>
        /// Linq26
        /// </summary>
        public static void Linq26()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //跳过不能被3整除的所有元素
            //这里和TakeWhiel又有些不一样。
            //TakeWhile遇到条件不满足的时候,就会return,
            //但是SkipWhile如果执行到能被三整除的数,那么其后面的元素就不会继续比较了
            //同样,想象一下执行过程
            //5%3!=0==true; 4%3!=0==true; 1%3!=0==true;
            //3%3!=0==false; 运行到这里的时候,后面的就不再比较.
            //所以输出结果中会有8、7、2、0这几个不满足条件的元素
            var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);
            Console.WriteLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Linq27
        /// </summary>
        public static void Linq27()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var laterNumbers = numbers.SkipWhile((n, index) => n >= index);
            Console.WriteLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
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
