using System;
using System.Linq;
using System.Collections.Generic;

namespace homwork
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var count = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else {
                    count[number] = 1;
                }


            }

            foreach (var number in count)
            {

                Console.WriteLine(number.Key + " -> " + number.Value);

            }

        }
    }
}
