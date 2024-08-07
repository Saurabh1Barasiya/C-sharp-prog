using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataConvertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, data type conversion is the process of converting a value from one data type to another.
            // This is often necessary when dealing with different types of data.
            // There are two main types of data type conversion in C#:
            // implicit conversion and explicit conversion.


            // Implicit Conversion
            // Implicit conversion is automatically performed by the C# compiler and does not require any special syntax.
            // It typically occurs when converting from a smaller to a larger data type, as there is no risk of data loss.  

            int num = 10;
            long longnum = num; // Implicit conversion from int to long

            float floatnum = 123.33F;
            double doublenum = floatnum;  // Implicit conversion from float to double.

            Console.WriteLine(longnum);
            Console.WriteLine(doublenum);



            // Explicit Conversion
            // Explicit conversion, also known as casting, is required when you need to convert between incompatible types or when there is a potential for data loss.
            // Explicit conversions are performed using cast operators.

            // Examples of Explicit

            double doubleNumber = 102010.245;
            int intNumber = (int)doubleNumber;   // Explicit conversion from double to int
            Console.WriteLine(intNumber); 


            long longNumber = 123456L;
            int smallnumber = (int)longNumber;   // Explicit conversion from long to int
            Console.WriteLine(smallnumber);




            // Using Helper Classes for Conversion
            // C# provides helper classes like Convert and methods like Parse and TryParse to facilitate conversion between different types.

            // Using the Convert Class
            // The Convert class provides methods to convert various types to other types.

            string str = "123";
            int intVal = Convert.ToInt32(str);  // Convert string to int

            bool boolVal = Convert.ToBoolean(1);  // Convert int to bool
            double doubleVal = Convert.ToDouble("123.45");  // Convert string to double

            Console.WriteLine(intVal);
            Console.WriteLine(boolVal);
            Console.WriteLine(doubleVal);



            //Using Parse and TryParse Methods
            //Parse methods convert a string representation of a number to its numeric equivalent.If the conversion fails, an exception is thrown.


            string str1 = "456";
            int intVal1 = int.Parse(str1);  // Convert string to int

            string floatStr = "78.90";
            float floatVal = float.Parse(floatStr);  // Convert string to float

            Console.WriteLine(intVal1);
            Console.WriteLine(floatVal);




            Console.ReadLine();

        }
    }
}
