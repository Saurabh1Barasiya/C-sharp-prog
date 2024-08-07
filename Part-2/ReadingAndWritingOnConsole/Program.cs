using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndWritingOnConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Use Console.WriteLine() to write a line of text to the console.
            // This method appends a newline character at the end of the text.

            Console.WriteLine("Hello my name is saurabh");

            // Use Console.ReadLine() to read input from the console.
            // This method waits for the user to input a line of text and press Enter.
            Console.WriteLine("Please enter some text : ");
            string data = Console.ReadLine();
            Console.WriteLine($"your entered text is : {data}");

            Console.ReadLine();
        }
    }
}
