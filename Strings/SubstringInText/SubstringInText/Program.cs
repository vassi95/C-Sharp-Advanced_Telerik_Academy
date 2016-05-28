using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string toFind = Console.ReadLine().ToLower();

            string toSearchIn = Console.ReadLine().ToLower();

            int curIndex = toSearchIn.IndexOf(toFind);

            int counter = 0;

            while (curIndex >= 0)
            {
                counter++;

                curIndex = toSearchIn.IndexOf(toFind, ++curIndex);
            }

            Console.WriteLine(counter);
        }
    }
}
