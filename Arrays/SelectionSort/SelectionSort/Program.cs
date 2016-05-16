﻿using System;

public class SelectionSort
{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int minIndex = 0;

        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length - 1; i++)
        {
            minIndex = i;

            for (int j = i + 1; j < length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                var temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine(arr[i]);
            if (i == length - 2)
            {
                Console.WriteLine(arr[i + 1]);
            }
        }
    }
}