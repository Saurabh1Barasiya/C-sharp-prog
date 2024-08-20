using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_Method_overloading
{
    // Method Overloading in C#

    // Method overloading is a feature in C# that allows you to have multiple methods in the same class with the same name but different signatures.
    // A "signature" in this context refers to the method's name combined with its parameter list (number, types, and order of parameters).
    // The return type is not considered part of the method signature.

    // Key Points of Method Overloading
    // Same Method Name: All overloaded methods must have the same name.
    // Different Parameter List: The methods must differ in one or more of the following:
        //The number of parameters.
        //The types of parameters.
        //The order of parameters.

    // Return Type: The return type can be different but cannot be used to differentiate overloaded methods.
    // The compiler relies solely on the method's signature (excluding the return type) to distinguish between them.


    public class Printer
    {
        public Printer() {
            Console.WriteLine("I am constructor....");
        }

        public void print(string text)
        {
            Console.WriteLine(text);
        }

        public void print(string text, int time)
        {
            for (int i = 0; i < time; i++)
            {
                Console.WriteLine(text);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Printer obj = new Printer();
            obj.print("Hello print this message");
            obj.print("Ye message ko print kar do", 3);
            Console.ReadLine();
        }
    }
}
