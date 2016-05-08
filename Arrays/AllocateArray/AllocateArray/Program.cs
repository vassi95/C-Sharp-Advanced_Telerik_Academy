using System;


namespace AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = i * 5;
            }
            for (int j = 0;  j < arr.Length; j++){
                Console.WriteLine(arr[j]);
                    }
        }
    }
}
