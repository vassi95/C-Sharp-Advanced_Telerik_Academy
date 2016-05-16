using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
               numbers =  Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchingNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(CountAppearance(numbers, searchingNumber));
        }

        private static int CountAppearance(int[] numbers, int searchingNumber)
        {
            int count = 0;
            foreach(int n in numbers)
            {
                if (n == searchingNumber){
                    count++;
                }
            }
            return count;
        }
    }
}
