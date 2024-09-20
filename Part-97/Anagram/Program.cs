using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        public static bool AreAnagram(string s1, string s2)
        {
            // if both string length are not same means not are anagram.
            if (s1.Length != s2.Length)
            {
                return false;
            }

            // remove all the spaces and make lower case.

            s1 = s1.Replace(" ", "").ToLower();
            s2 = s2.Replace(" ", "").ToLower();


            // Now convert to char Array and sort then.

            char[] charArray1 = s1.ToCharArray();
            char[] charArray2 = s2.ToCharArray();


            // sort the array.
            Array.Sort(charArray1);
            Array.Sort(charArray2);


            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            string s1 = "Listen";
            string s2 = "Silent";
            if (Program.AreAnagram(s1, s2))
            {
                Console.WriteLine("yes anagram");
            } 
            else {
                Console.WriteLine("No not anagram");
            }

            Console.ReadLine();
        }
    }
}
