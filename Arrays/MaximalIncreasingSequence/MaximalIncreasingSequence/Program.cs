using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            long[] maxSequence = new long[n]; 
            int[] theNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                theNumbers[i] = int.Parse(Console.ReadLine());
            }
            int maxSeqIndex = 0;
            int maxSeqEqualElements = 1;
            
            for (int i = 1; i < n; i++)
            {
                if (theNumbers[i] > theNumbers[i - 1])
                {
                    maxSeqEqualElements++;
                    maxSequence[maxSeqIndex] = maxSeqEqualElements;
                }
                else
                {
                    maxSeqEqualElements = 1;
                    maxSeqIndex++;
                }
            }
            
            Console.WriteLine(maxSequence.Max());
        }
    }
}