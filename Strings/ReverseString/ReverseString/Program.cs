using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            var toReverse = Console.ReadLine();

            StringBuilder ReverseInput =
                new StringBuilder(toReverse.Length);

            foreach (var Letter in toReverse)
            {
                ReverseInput.Insert(0, Letter);
            }

            Console.WriteLine(ReverseInput);
        }
    }
}
