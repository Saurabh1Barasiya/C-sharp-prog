using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_constructor
{

    // A parameterized constructor in C# is a constructor that takes one or more parameters.
    // allowing you to initialize an object with specific values at the time of its creation.
    // This is useful when you want to set initial values for an object's properties or fields directly.

    public class Myclass
    {
        public string Name;
        public int Age;
        public DateTime Dob;

        public Myclass(string name,int age,DateTime dob) {
            Name = name;
            Age = age;
            Dob = dob;
        }

        public void disPlay()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Dob);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass("Saurabh",26,DateTime.Now);
            obj.disPlay();
            Console.ReadLine();
        }
    }
}
