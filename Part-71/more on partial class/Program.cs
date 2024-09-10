using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_partial_class
{

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Showdata()
        {
            Console.WriteLine($"Employee: {Name}, Age: {Age}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Name = "Alem";
            manager.Age = 50;
            manager.Department = "IT";
            manager.Bonus = 50000.00;
            manager.Showdata();

            Console.ReadLine();

        }
    }
}
