using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BinaryToDecimal
{
    class Program
    {

        static BigInteger BinaryToDecimal(string binary)
        {
            BigInteger sum = 0;

            foreach (char bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            string n = (Console.ReadLine());
            Console.WriteLine(BinaryToDecimal(n));

        }
    }
}
