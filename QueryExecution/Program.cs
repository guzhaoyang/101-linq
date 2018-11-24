using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq101();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq99
        /// </summary>
        public static void Linq99()
        {
            // Sequence operators form first-class queries that 
            // are not executed until you enumerate over them.   
            //序列运算符形成一个不执行的一流查询，直到您枚举它们为止。
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q =
                from n in numbers
                select ++i;

            // Note, the local variable 'i' is not incremented 
            // until each element is evaluated (as a side-effect): 
            //注意，在每个元素被求值（作为副作用）之前，本地变量“i”是不会递增的。
            foreach (var v in q)
            {
                Console.WriteLine("v = {0}, i = {1}",v, i);
            }
        }

        /// <summary>
        /// Linq100
        /// </summary>
        public static void Linq100()
        {
            // Methods like ToList() cause the query to be 
            // executed immediately, caching the results. 
            //方法tolist()导致查询立即执行，缓存结果

            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q = (
                from n in numbers
                select ++i
                ).ToList();

            // The local variable i has already been fully 
            // incremented before we iterate the results:
            //在迭代结果之前，本地变量i已经完全增加了。
            foreach (var v in q)
            {
                Console.WriteLine("v = {0}, i = {1}", v, i);
            }
        }

        /// <summary>
        /// Linq101
        /// </summary>
        public static void Linq101()
        {
            // Deferred execution lets us define a query once 
            // and then reuse it later after data changes.
            //延迟执行允许我们定义一次查询，然后在数据更改后重用它。

            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNumbers =
                from n in numbers
                where n <= 3
                select n;

            Console.WriteLine("First run numbers <= 3:");
            foreach (var n in lowNumbers)
            {
                Console.WriteLine(n);
            }

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object, 
            // lowNumbers, will be iterating over the new state 
            // of numbers[], producing different results: 
            //本次运行期间，相同的查询对象，lownumbers，将超过numbers[]新状态的迭代，产生不同的结果：
            Console.WriteLine("Second run numbers <= 3:");
            foreach (var n in lowNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
