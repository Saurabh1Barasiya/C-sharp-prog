using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "saasaa";
            int start = 0;
            int end = s.Length - 1;
            while (start <= end)
            {
                if (s[start] != s[end])
                {
                    Console.WriteLine("String is not palindrome..");
                    break;
                   
                }
                else
                {
                    start++;
                    end--;
                }
            }

            if (start >= end)
            {
                Console.WriteLine("palindrome string");
            }

            Console.ReadLine();
        }
    }
}
