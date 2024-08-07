using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte aByte = 255;  // byte.
            int anInt = 123456; // int.

            // for long datatype you have to mention L in the end.
            long aLong = 1234567890L; // Long.



            // Floating-point types

            // when you want float to must use F in the last
            // when we are dealing with float so maximum time we use Double.
            float aFloat = 12.34F;
            double aDouble = 123.456;



            // Decimal type - you have to mention M  at the end when we use Decimal data type.
            decimal aDecimal = 12345.6789M;



            // Character type
            char aChar = 'A';

            // Boolean type
            bool aBool = true;

            // String type
            string aString = "Hello, World!";


            // Nullable type
            int? aNullableInt = null;


            // Displaying values
            Console.WriteLine($"byte: {aByte}");
            Console.WriteLine($"int: {anInt}");
            Console.WriteLine($"long: {aLong}");
            Console.WriteLine($"float: {aFloat}");
            Console.WriteLine($"double: {aDouble}");
            Console.WriteLine($"decimal: {aDecimal}");
            Console.WriteLine($"char: {aChar}");
            Console.WriteLine($"bool: {aBool}");
            Console.WriteLine($"string: {aString}");
            Console.WriteLine($"nullable int: {aNullableInt}");

            Console.ReadLine();



        }
    }
}
