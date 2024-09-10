using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_C_
{
    // In C#, an interface is a contract that defines a set of methods, properties, events, or indexers
    // without providing any implementation. Classes or structs that implement an interface must provide concrete implementations
    // for all the members defined in the interface.


    public interface IEmployee
    {
        // isme kabhi bhi fields (varriable nahi bante h).

        void Work();  // Method declaration.
        int Salary { get; set; }  // Property declaration.
    }


    // A class or struct that implements an interface must provide concrete implementations for all the members of that interface.

    public class Manager : IEmployee
    {
        public int Salary { get; set; }

        public void Work()
        {
            Console.WriteLine("Manager manage the team : ");
            Console.WriteLine($"Getting Salary {Salary} : ");
        }
    }

    public class Developer : IEmployee
    {
        public int Salary { get ; set ; }

        public void Work()
        {
            Console.WriteLine("Developer writing the code... : ");
            Console.WriteLine($"Getting Salary {Salary} : ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // parent class ka variable child class ke object ko store kar sakta h.

            IEmployee manager = new Manager { Salary = 70000 };
            IEmployee developer = new Developer { Salary = 50000 };
            manager.Work();
            developer.Work();

            Console.WriteLine("----------------------------------------------------------------------");

            IEmployee mana = new Manager();
            IEmployee deve = new Developer();
            mana.Salary = 600000;
            deve.Salary = 50000;
            mana.Work();
            deve.Work();

            Console.ReadLine();
        }
    }
}
