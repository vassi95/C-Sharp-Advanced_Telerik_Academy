using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class Program
    {
        static string Greeting(string name)
        {
            return string.Format("Hello, {0}!", name);
        }

        static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine(Greeting(name));
        }
    }
}
