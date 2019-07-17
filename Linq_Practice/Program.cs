using System;
using System.Linq;

namespace Linq_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //min number
            int res = Numbers.Min();
            Console.WriteLine("Min Number= {0}", res);
            //min even number
            res = Numbers.Where(x => x % 2 == 0).Min();
            Console.WriteLine("Min Even Number= {0}", res);
            //max even number
            res = Numbers.Where(x => x % 2 == 0).Max();
            Console.WriteLine("Max Number= {0}", res);
            //average even number
            res = (int) Numbers.Where(x => x % 2 == 0).Average();
            Console.WriteLine("Average Number= {0}", res);
            //count even number
            res = (int) Numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine("Count Number= {0}", res);
            //Aggregate Function
            string[] countries = { "USA", "Japan", "Thailand", "Pakistan", "Canada" };
            //now we'll use aggregate to get string = "USA, Japan, Thailand, Pakistan, Canada"
            string strRes = countries.Aggregate((x, y) => x + ", " + y);
            Console.WriteLine("Modified String: {0}", strRes);
            //product of Numbers
            res = Numbers.Aggregate((a, b) => a * b);
            //below version multiply 1st num with 10 and store res in a, then cycle continues
            //res = Numbers.Aggregate(10, (a, b) => a * b);
            Console.WriteLine("Product: {0}", res);



        }
    }
}
