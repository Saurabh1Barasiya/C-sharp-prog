using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 1");
            if (5>1)
            {
                Console.WriteLine("Inside if block");
            }
            else
            {
                Console.WriteLine("Else block");
            }



            Console.WriteLine("Example 2");
            if (false)
            {
                Console.WriteLine("Inside if block");
            }
            else
            {
                Console.WriteLine("Else block");
            }






            Console.ReadLine();
        }
    }
}
