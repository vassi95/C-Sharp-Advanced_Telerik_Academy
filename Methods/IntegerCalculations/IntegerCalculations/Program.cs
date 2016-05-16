using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class Program
    {
        static void Main()
        {
            int[] arrayOfInts = new int[5];
            arrayOfInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Min(arrayOfInts));
            Console.WriteLine(Max(arrayOfInts));
            Console.WriteLine("{0:f2}", Average(arrayOfInts));
            Console.WriteLine(Sum(arrayOfInts));
            Console.WriteLine(Product(arrayOfInts));
        }

        static int Min( int[] array)
        {
            return array.Min();
        }
        static int Max( int[] array)
        {
            return array.Max();
        }
        static double Average( int[] array)
        {
            List<int> list = array.ToList();
            return list.Average();
        }
        static long Sum( int[] array)
        {
            return array.Sum();
        }
        static long Product( int[] array)
        {
            long product = 1;
            foreach (var item in array)
            {
                product *= item;
            }
            return product;
        }
    }
}
