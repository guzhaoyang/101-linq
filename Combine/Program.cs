using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Combine
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq98();
            Console.ReadKey();
        }

        public static void Linq98()
        {
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            int dotProduct = vectorA.Combine(vectorB, (a, b) => a * b).Sum();

            Console.WriteLine("Dot product: {0}", dotProduct);
        }
    }

    public static class CustomSequenceOperators
    {
        public static IEnumerable<TResult> Combine<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> func)
        {
            IEnumerator e1 = first.GetEnumerator(), e2 = second.GetEnumerator();

            while (e1.MoveNext() && e2.MoveNext())
            {
                yield return func((TFirst)e1.Current, (TSecond)e2.Current);
            }
        }

        //public static IEnumerable<TResult> Combine<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        //{
        //    IEnumerator e1 = first.GetEnumerator(), e2 = second.GetEnumerator();

        //    while (e1.MoveNext() && e2.MoveNext())
        //    {
        //        yield return resultSelector((TFirst)e1.Current, (TSecond)e2.Current);
        //    }
        //}
    }
}
