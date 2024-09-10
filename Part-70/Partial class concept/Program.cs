using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class_concept
{
    // In C#, a partial class allows you to split the definition of a class into multiple files.
    // Each file contains a part of the class definition, and when the project is compiled, all parts are combined into a single class.

    // Why use a partial class?

    // Organize code: If a class is very large, you can break it into separate files to make it easier to manage.

    // hamne yaha 2 new file banayi h Program1.cs and Program2.cs but dono me class ka name same hai. prefix partial keyword ke shat.
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "Saurabh";
            person.Lastname = "Barasiya";
            person.Age = 30;

            person.ShowData();
            Console.ReadLine();
        }
    }


    // Key points about partial classes:
        // The partial keyword must be used in all parts of the class.
        // All parts must be in the same namespace.
        // All parts must have the same access modifiers(like public or internal).
        // When compiled, all parts are treated as one single class.

}
