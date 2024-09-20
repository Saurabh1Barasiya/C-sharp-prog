using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_queston
{
   

    internal class Program
    {
        public static string Reverse(string s1)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int end = s1.Length - 1;
            while (end >= 0)
            {
                stringBuilder.Append(s1[end]);
                end --;
            }
            return stringBuilder.ToString();

        }

        static void Main(string[] args)
        {
            string s = "saurabh";
            string reversestring = Program.Reverse(s);
            Console.WriteLine(reversestring);
            Console.ReadLine();
        }
    }
}
