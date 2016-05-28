using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                answer.AppendFormat("\\u{0:X4}", (int)input[i]);
                
            }

            

            Console.WriteLine(answer.ToString());
        }
    }
}
