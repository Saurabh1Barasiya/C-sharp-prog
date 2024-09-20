using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        public static bool Armstrong(int number)
        {
            int remaningNumber = number;
            int totel = 0;
            int cube = 0;
            int lastdigit;
            while (remaningNumber != 0)
            {
                // getting the last digit .

                lastdigit = remaningNumber % 10;

                // make qube 
                cube = lastdigit * lastdigit * lastdigit;

                // add totel numbers.
                totel += cube;

                // get remaning numbers  .

                remaningNumber = remaningNumber / 10;   

            }

            if(totel == number)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {
            bool retVal = Program.Armstrong(153);
            Console.WriteLine(retVal);
            Console.ReadLine();
        }
    }
}
