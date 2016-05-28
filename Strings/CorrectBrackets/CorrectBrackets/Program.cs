using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static void Main()
        {
            string expression = Console.ReadLine();

            bool correctBrackets = true;

            int counter = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (ch == '(')
                {
                    counter++;
                }
                else if (ch == ')')
                {
                    counter--;

                    if (counter < 0)
                    {
                        correctBrackets = false;
                        Console.WriteLine("Incorrect");
                        return;
                    }
                }
            }

            if (counter != 0)
            {
                correctBrackets = false;
                Console.WriteLine("Incorrect");
            }

            if (correctBrackets)
            {
                Console.WriteLine("Correct");
            }

        }
    }
}
