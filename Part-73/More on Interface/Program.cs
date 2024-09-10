using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_on_Interface
{
    public interface Iworker
    {
        void Work();
    }

    public interface Imanager
    {
        void Work();
    }

    public class Employee : Iworker, Imanager
    {
        void Imanager.Work()
        {
            Console.WriteLine("manager is working ....");
        }

        void Iworker.Work()
        {
            Console.WriteLine("Employee is working ....");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // call both method.
            Iworker iworker = new Employee();
            iworker.Work();

            Imanager imanager = new Employee();
            imanager.Work();

            // another way is to typecaste.

            Employee emp = new Employee();
            ((Iworker)emp).Work();
            ((Imanager)emp).Work();

            Console.ReadLine();

        }
    }
}
