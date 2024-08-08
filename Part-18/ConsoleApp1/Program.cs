using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var and dynamic keyword.


            // The var keyword is used for implicit typing.
            // When you declare a variable with var, the compiler infers the type of the variable based on the value assigned to it.
            // The type is determined at compile time and is fixed, meaning that the type of the variable cannot change after it's assigned.

            var name = "saurabh";
            var number = 10;

            Console.WriteLine(name);
            Console.WriteLine(number);

            // number = "Suhani"; // error dont uncomment.
            // meaning that the type of the variable cannot change after it's assigned.




            // Dynamic keyword.

            // The dynamic keyword is used for dynamic typing.
            // When you declare a variable with dynamic, the type is determined at runtime rather than compile time.
            // This allows you to bypass compile - time type checking, making the variable more flexible but also more prone to runtime errors.


            dynamic data = 100;
            Console.WriteLine(data); // 100
            data = "saurabh";
            Console.WriteLine(data); // saurabh
            data = DateTime.Now;
            Console.WriteLine(data); // 8/8/2024 3:55:16 PM
            data = true;
            Console.WriteLine(data); // true


            // The dynamic variable value changes its type at runtime.
            // It starts as an int, then becomes a string, and finally a DateTime.
            // Limited IntelliSense Support (since the type is unknown until runtime)






            Console.ReadKey();

        }
    }
}