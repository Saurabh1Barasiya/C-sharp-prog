using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Static_properties
{
    // with the help of static properties we can eaisly set the vaue of static variables.
    // static matlab class se realated usko object bhi access kar sakte h but.
    // every object ke paas instace mambers ki hi copy hoti h
    // static mamber always 1 hi rahega.  if koi object usko change karta h to vo change har object ke liye hoga. or class ke liye bhi. 



    // In C#, static properties are properties that belong to the class itself rather than to any specific instance of the class.
    // This means that you can access and modify static properties without creating an object of the class.
    // Static properties are shared among all instances of a class, and they are useful when you want to keep a single value or state across all instances.


    // A static property is defined using the static keyword before the property type.
    // You can access static properties using the class name, without needing to create an object.
    // Since static properties are shared, changing the value of a static property in one place affects its value everywhere.

    // Static properties are initialized when the class is first accessed, and they exist for the lifetime of the application.



    public class Example
    {
        public static string name;
        public static string _Name {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null");
                }
                else
                {
                    name = value;
                }
            }
            get 
            {
                return name;
            }
            
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {


            Example._Name = "Saurabh";
            Console.WriteLine(Example._Name);

            //Example obj = new Example();
            Console.ReadLine();
        }
    }
}
