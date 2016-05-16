using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class Program
    {
        static void Main()
        {

            short number = short.Parse(Console.ReadLine());
            string result = "";
            if (number < 0)
                result = "1" + ToBin((short)(32768 + number)).PadLeft(15, '0');
            else
                result = ToBin(number).PadLeft(16, '0');
            Console.WriteLine(result);
        }

        static string ToBin(short number)
        {
            string result = "";
            while (number > 0)
            {
                result = (number % 2).ToString() + result;
                number = (short)(number / 2);
            }
            return result;
        }
    }
}
