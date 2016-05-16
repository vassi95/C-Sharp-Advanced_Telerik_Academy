using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SortArray(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void SortArray(int[] array)
        {
            Array.Sort(array);
        }
    }
}
