using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int numberX = int.Parse(Console.ReadLine());

            int counter = 0;
            int startIndex = 0;
            int endIndex = length - 1;
            int midIndex = (endIndex - startIndex) / 2;
            int result = -1;

            while (counter <= length / 2)
            {
                if (arr[midIndex] == numberX)
                {
                    result = midIndex;
                    break;
                }
                else if (arr[midIndex] < numberX)
                {
                    startIndex = midIndex + 1;
                    midIndex = (endIndex + startIndex) / 2;
                    counter++;
                }
                else
                {
                    endIndex = midIndex - 1;
                    midIndex = (startIndex + endIndex) / 2;
                    counter++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
