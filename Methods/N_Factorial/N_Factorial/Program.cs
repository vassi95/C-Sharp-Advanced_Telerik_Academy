using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(calculateFactorial(n));

        }
        static BigInteger calculateFactorial(int num)
        {
            BigInteger fact = 0;
if(num == 1 || num==0)
            {
                return 1;
            }
else
            {
                return calculateFactorial(num - 1)*num;
            }
        }
    }
}
