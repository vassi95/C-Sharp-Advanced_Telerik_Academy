using System;
using System.Collections.Generic;
using System.Linq;


namespace _3.CompareCharArrays
{
    class Program
    {
        static void Main()
        {

            string OneSmaller = "<";
            string TwoSmaller = ">";
            string Equal = "=";

            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();


            if (inputA.Length < inputB.Length)
            {
                inputA = inputA.PadRight(inputB.Length, (char)(0));
            }
            else if (inputA.Length > inputB.Length)
            {
                inputB = inputB.PadRight(inputA.Length, (char)(0));
            }


            char[] arrayA = inputA.ToCharArray();
            char[] arrayB = inputB.ToCharArray();


            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] < arrayB[i])
                {
                    Console.WriteLine(OneSmaller);
                    return;
                }
                else if (arrayA[i] > arrayB[i])
                {
                    Console.WriteLine(TwoSmaller);
                    return;
                }
            }

            Console.WriteLine(Equal);
        }
    }
}