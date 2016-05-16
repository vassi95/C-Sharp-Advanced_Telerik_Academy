using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] pol1 = new int[n];
            int[] pol2 = new int[n];
            int[] result = null;
            pol1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            pol2 = Console.ReadLine()
                      .Split(' ')
                      .Select(int.Parse)
                      .ToArray();
            result = calculateSum(pol1, pol2);
            Console.WriteLine(String.Join(" ", result));

        }

        static int[] calculateSum(int[] pol1, int[] pol2)
        {
            int[] sum = new int[pol1.Length];
            for(int i=0; i<pol1.Length; i++)
            {
                sum[i] = pol1[i] + pol2[i];
            }
            return sum;
        }
    }
}
