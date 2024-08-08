using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_constructor
{
    // If you do not define any constructor, C# will implicitly create a default constructor for you:
    public class Test
    {
        public int Number;
        public string Text;

        // agar ham constructor nahi banayege to C# autometcally default contructor bana dega.

        //public Test()
        //{
        //    Number = 0;
        //    Text = null;
        //}


    }

    public class MyClass
    {
        public int Number;
        public string Text;

        // Default constructor
        public MyClass()
        {
            Number = 0;
            Text = "Default text";
            Console.WriteLine("I am called"); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // default constructor.


            // In C#, a default constructor is a constructor that does not take any parameters.
            // If you do not define any constructor in your class, C# automatically provides a default constructor
            // that initializes all member variables to their default values (e.g., 0 for integers, null for reference types).

            MyClass obj =  new MyClass();
            Console.WriteLine(obj.Number); // 0
            Console.WriteLine(obj.Text);   // default text

            // Creating object of Test Class.

            Console.WriteLine("creating obj 2.");
            Test t1 = new Test();
            Console.WriteLine(t1.Number); // 0
            Console.WriteLine(t1.Text);  // null


            Console.ReadLine();
        }
    }
}
