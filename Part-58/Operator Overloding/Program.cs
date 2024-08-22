using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloding
{

    // Operator overloading in C# allows you to redefine the behavior of operators for user-defined types, such as classes and structs.
    // This feature enables your custom objects to interact using standard operators like +, -, *, ==, etc., in a way that is intuitive and consistent with their behavior.

    // Static Method: The operator overloading method must be public static.
    // Operator Keyword: The method uses the operator keyword followed by the operator symbol.
    // Return Type: The method must return a value, typically of the same type as the class or struct.
    // Parameters: At least one parameter must be of the type of the class or struct where the operator is overloaded.


    // Let's create a simple Point class to represent a point in 2D space and overload the + operator.

    public class Example
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Example(int x, int y) {
            X = x;
            Y = y;
        }
        
        // Overloading the + operator.

        // agar app operator overloding karte h to vo method public and static honi cahiye.
        // operator keyword ka use karna padega.
        // fir operator ka symbol (+) jisko overload karna h .

        public static Example operator +(Example a1, Example a2)
        {
            Example newObject = new Example(0, 0);
            newObject.X = a1.X + a2.X;
            newObject.Y =  a1.Y + a2.Y;
            return newObject;
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj1 = new Example(10, 20); 
            Example obj2 = new Example(10, 20);

            Example obj3 = obj1 + obj2;

            Console.WriteLine("New data shown below...");
            Console.WriteLine(obj3.X);  // 20
            Console.WriteLine(obj3.Y);  // 40

            Console.ReadLine();
        }
    }
}
