using System;

public class MaximalKSum
{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int maxSumLength = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        int maxSum = 0;

        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        Array.Reverse(arr);

        for (int i = 0; i < maxSumLength; i++)
        {
            maxSum += arr[i];
        }

        Console.WriteLine(maxSum);
    }
}