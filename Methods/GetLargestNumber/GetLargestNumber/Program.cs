using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n1 = sequence[0];
            int n2 = sequence[1];
            int n3 = sequence[2];
           
            if (getMax(n1, n2) > n3)
            {
                Console.WriteLine(getMax(n1, n2));
            }
            else
            {
                Console.WriteLine(n3);
            }
        }

        static int getMax(int num1, int num2)
        {
             return (num1 > num2 ? num1 : num2);
        }
    }
}
