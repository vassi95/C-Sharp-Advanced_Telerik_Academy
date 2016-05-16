using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine();
            Console.WriteLine(ReverseNum(num));
        }

        private static string ReverseNum(string number)
        {
            string reversed = string.Empty;
            for(int i =number.Length-1; i>=0; i--)
            {
                reversed += number[i];
            }
            return reversed;
        }
    }
}
