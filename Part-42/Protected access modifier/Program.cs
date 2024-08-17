using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Protected_access_modifier
{
    // The protected access modifier in C# is used to control the accessibility of a class member.
    // When a member is marked as protected,it is accessible within its own class and by any derived classes (child classes),


    // Accessible within the class where it is declared.
    // Accessible in derived classes(child classes).
    // Not accessible from outside these classes(i.e., not accessible by instances of the class or by other unrelated classes).


    class A
    {
        protected string name = "Saurabh";

        protected void showData()
        {
            Console.WriteLine("I am procted function of base class.");
        }
    }

    class B : A {
        public B()
        {
            Console.WriteLine($"accessing procted variaable of parent class {name}");
        }

        // access procted function of parent class.
        public void show()
        {
            showData();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            // protected members ko class ke bahar direct access nahi kar sakte 
            // but inheritance ho raha h to proctected mambers inherited ho jate h.
            
            //a.name;

            B obj = new B();

            // ham direct access nahi kar sakte h protected mambers ko.
            // but helper function ka use karke kar sakkte h.

            // direct access to nahi kar sakkte h . but child class me helper function ka use kar sakte h.
            // Console.WriteLine(obj.name);
            //obj.showData();



            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
