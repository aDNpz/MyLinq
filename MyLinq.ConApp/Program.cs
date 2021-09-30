using System;
using MyLinq.Logic;


namespace MyLinq.ConApp
{
    class Program
    {
        static int[] IntArray = new[] { 7, 9, 2, 4, 7, 16, 34, 53, 76, 11, 13 };
        static void Main(string[] args)
        {
            Console.WriteLine("MyLinq-Demo");
            var even = IntArray.Filter(x => x % 2 == 0)
                                .ForEach(x => Console.WriteLine(x));

            var doubleArray = IntArray.Map(x => x * 1.0)
                                      .ForEach(x => Console.WriteLine((x);
        }
    }
}
