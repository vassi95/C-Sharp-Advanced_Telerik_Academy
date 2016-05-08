using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];

            for(int i=0; i < n; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                second[j] = int.Parse(Console.ReadLine());
            }

            bool isEqual = Enumerable.SequenceEqual(first, second);
            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
