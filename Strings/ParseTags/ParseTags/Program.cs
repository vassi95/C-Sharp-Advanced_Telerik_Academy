using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {

            string toUpperCase = Console.ReadLine();
            string[] array = toUpperCase.Split('<', '>');
            for (int i = 0; i < array.Length; i++) {
                if (array[i].ToString().Equals("upcase")) {
                    do {
                        if (!array[i].ToString().Equals("upcase") && !array[i].ToString().Equals("/upcase")) {
                            array[i] = array[i].ToUpper();
                            Console.Write(array[i]); } i++; }
                    while (!(array[i - 1].ToString().Equals("/upcase")));
                    i--;
                } else {
                    Console.Write(array[i]); } } Console.WriteLine(); 
}
    }
}
