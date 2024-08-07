using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuiltInDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# provides a variety of built-in data types,
            // each designed to handle different kinds of data efficiently.
            // These data types are categorized into value types and reference types. Here's a detailed explanation of each category and the common built-in data types:



            // 1. Integral Types:

            // byte: Represents an 8 - bit unsigned integer. Range: 0 to 255.
            // sbyte: Represents an 8 - bit signed integer. Range: -128 to 127.
            // short: Represents a 16 - bit signed integer. Range: -32,768 to 32,767.
            // ushort: Represents a 16 - bit unsigned integer. Range: 0 to 65,535.
            // int: Represents a 32 - bit signed integer. Range: -2,147,483,648 to 2,147,483,647.
            // uint: Represents a 32 - bit unsigned integer. Range: 0 to 4,294,967,295.
            // long: Represents a 64 - bit signed integer. Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            // ulong: Represents a 64 - bit unsigned integer. Range: 0 to 18,446,744,073,709,551,615.


            // 2. Floating-Point Types:

            // float: Represents a single - precision 32 - bit floating point. Approximate range: ±1.5e−45 to ±3.4e38.
            // double: Represents a double-precision 64 - bit floating point. Approximate range: ±5.0e−324 to ±1.7e308.


            // 3.Decimal Type:

            //decimal: Represents a 128 - bit precise decimal value with 28 - 29 significant digits. Suitable for financial and monetary calculations.Range: ±1.0 x 10 ^ -28 to ±7.9 x 10 ^ 28.

            // 4.Character Type:

            // char: Represents a single 16 - bit Unicode character.Range: U + 0000 to U + FFFF.

            // 5.Boolean Type:

            //bool: Represents a Boolean value(true or false).

            // 6. Structs and Enums:

            // struct: Value types that can encapsulate data and related functionality.
            // enum: A distinct type consisting of a set of named constants called the enumerator list.




            // -----------------------------------------------------------------------------------------------
            // Reference type.

            // Reference types store references to their data(objects), which are stored on the heap.
            // Here are the main reference types in C#:


            //Object Type:
            //object: The base type from which all other types, both value and reference, derive.It can store any data type.

            //String Type:
            //string: Represents a sequence of Unicode characters. Strings are immutable in C#.

            //Class Type:
            //class: A reference type that can encapsulate data and related functionality.

            //Interface Type:
            //interface: A contract that defines a set of methods and properties that implementing classes must provide.

            //Array Type:
            //array: A collection of elements of the same type.Arrays are reference types.





            // Nullable Types
            // Value types can be made nullable using the ? syntax, allowing them to represent an undefined value. For example, int? can hold any 32 - bit integer value or null.
            // Nullable types are also shown with int?.
        }
    }
}
