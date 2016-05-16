using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.Numerics;


namespace DecimalToBinary
{
    class Program
    {
        static string DecimaToBinary(BigInteger decValue)
        {
            string result = "";

            do
            {
                BigInteger reminder = decValue % 2;
                result = reminder + result;
                decValue /= 2;
            } while (decValue > 0);
            return result;
        }
        static void Main()
        {
            BigInteger decValue = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(DecimaToBinary(decValue));
        }
    }
}
