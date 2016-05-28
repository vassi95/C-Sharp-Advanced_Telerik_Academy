﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - 9 && text[i] == '<' && text.Substring(i, 9) == "<a href=\"")
                {
                    var endOfTag = text.IndexOf("<", i + 9);
                    var endOfUrl = text.IndexOf("\">", i + 9);

                    var url = text.Substring(i + 9, endOfUrl - i - 9);
                    var body = text.Substring(endOfUrl + 2, endOfTag - endOfUrl - 2);

                    sb.Append(string.Format("[{0}]({1})", body, url));

                    i = endOfTag + 3;
                }
                else
                {
                    sb.Append(text[i]);
                }

            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
