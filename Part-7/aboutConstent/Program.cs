using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace aboutConstent
{
    internal class Program
    {
        const int MyIntConstant = 10;
        const double MyDoubleConstant = 20.5;
        const string MyStringConstant = "Hello, World!";
        const char MyCharConstant = 'A';


        static void Main(string[] args)
        {
            // constants
            // In C#, constants are immutable values which are known at compile time and do not change for the life of the program.
            // They are defined using the const keyword. Constants can only be of simple data types like int, float, double, char, string, etc., and cannot be modified after they are declared.


            // Declaring Constants
            // To declare a constant, you use the const keyword followed by the data type and the name of the constant.
            // The value of the constant must be assigned at the time of declaration.

            const int number  = 1000;
            Console.WriteLine(number);



            // Accessing and printing constants
            Console.WriteLine($"Integer constant: {MyIntConstant}");
            Console.WriteLine($"Double constant: {MyDoubleConstant}");
            Console.WriteLine($"String constant: {MyStringConstant}");
            Console.WriteLine($"Char constant: {MyCharConstant}");

            // Attempting to modify a constant (uncommenting the below line will cause a compile-time error)
            // MyIntConstant = 15;

            Console.ReadLine();
        }
    }
}
