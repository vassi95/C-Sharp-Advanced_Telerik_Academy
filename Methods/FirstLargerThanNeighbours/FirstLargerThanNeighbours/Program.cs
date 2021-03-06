﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(checkForLarger(numbers));
        }

        static int checkForLarger(int[] arr)
        {
            int index = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }

        return index;


        }
    }
}