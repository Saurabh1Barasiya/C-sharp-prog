using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_statement_break_continue_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("break");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("continue");

            for (int i = 0; i < 10; i++)
            {
                if (i <= 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            // goto.
            Console.WriteLine("go to...");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto jump;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("one...");
            Console.WriteLine("two...");
            Console.WriteLine("three...");

            // its a label for goto. statement.
            jump:
                Console.WriteLine("done");


            Console.ReadKey();
        }
    }
}
