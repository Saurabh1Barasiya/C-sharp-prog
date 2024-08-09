using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Copy_constructor
{
    // A copy constructor in C# is a special constructor used to create a new object as a copy of an existing object.
    // It allows for the creation of a new instance that has the same values as an existing instance.
    // This is particularly useful when you want to duplicate an object with its current state.

    public class Example
    {
        public string Name;
        public int Age;

        public Example(string name,int age) { 
            Name = name;
            Age = age;
        }

        // copy contructor
        public Example(Example example) {
            Name = example.Name;
            Age = example.Age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example("jhon",25);

            // Creating a new object using the copy constructor.
            Example obj1 = new Example(obj);


            Console.WriteLine("Data of object 1");
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);

            Console.WriteLine("Data of object 2");
            Console.WriteLine(obj1.Name);
            Console.WriteLine(obj1.Age);

            Console.ReadLine();

        }
    }
}
