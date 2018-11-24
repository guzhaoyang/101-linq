using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq66();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq65
        /// </summary>
        public static void Linq65()
        {
            var numbers =
                from n in Enumerable.Range(100, 50)
                select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            foreach (var n in numbers)
            {
                Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
        }

        /// <summary>
        /// Linq66
        /// </summary>
        public static void Linq66()
        {
            var numbers = Enumerable.Repeat(7, 10);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
