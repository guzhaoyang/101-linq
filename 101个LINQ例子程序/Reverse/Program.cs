using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq39();
            Console.ReadKey();
        }

        public static void Linq39()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var reversedIDigits = (
                from d in digits
                where d[1] == 'i'
                select d)
                .Reverse();//反转序列中的元素
            Console.WriteLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                Console.WriteLine(d);
            }
        }
    }
}
