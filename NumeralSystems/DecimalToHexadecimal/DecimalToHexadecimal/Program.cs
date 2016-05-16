using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DecimalToHexadecimal
{
    class Program
    {

        const string HexDigits = "0123456789ABCDEF";

        static void Main(string[] args)
        {

            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());

          

            Console.WriteLine(DecimalToHex(inputNumber));
        }

        static string DecimalToHex(BigInteger decValue)
        {

            string result = "";

            do
            {
                BigInteger value = decValue % 16;
                result = HexDigits[(int)value] + result;
                decValue /= 16;

            } while (decValue != 0);

            return result;
        }

    }
}
