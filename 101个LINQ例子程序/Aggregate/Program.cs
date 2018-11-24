using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq93();
            Console.ReadKey();
        }

        //https://www.lanhusoft.com/Article/233.html Aggregate博客

        /// <summary>
        /// Linq92
        /// </summary>
        public static void Linq92()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine("Total product of all numbers: {0}", product);
        }

        /// <summary>
        /// Linq93
        /// </summary>
        public static void Linq93()
        {
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            double endBalance = attemptedWithdrawals.Aggregate(startBalance,
                (balance, nextWithdrawal) => ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Console.WriteLine("Ending balance: {0}", endBalance);
        }
    }
}
