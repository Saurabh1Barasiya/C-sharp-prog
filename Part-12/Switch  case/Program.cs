using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch__case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the operator");

            string op = Console.ReadLine();

            switch (op){
                case "+":
                        Console.WriteLine("add");
                        break;
                case "-":
                        Console.WriteLine("subtract");
                    break;
                case "*":
                        Console.WriteLine("multiply");
                        break;
                case "/":
                        Console.WriteLine("divide");
                        break;
                default:
                       Console.WriteLine("Invalid Operator...");
                        break ;
            }
            Console.ReadLine();
        }
    }
}
