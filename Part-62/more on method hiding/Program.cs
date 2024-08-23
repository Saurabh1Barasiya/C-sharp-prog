using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_method_hiding
{
    public class Employee
    {
        public string Firstname;
        public string Lastname;

        public void ShowFullName()
        {
            Console.WriteLine($"First name {Firstname} and lastname {Lastname}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void ShowFullName()
        {
            Console.WriteLine($"First name {Firstname} and lastname {Lastname} PTE");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public new void ShowFullName()
        {
            Console.WriteLine($"First name {Firstname} and lastname {Lastname} FTE");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee parttimeemployee = new PartTimeEmployee();
            parttimeemployee.Firstname = "Jhon";
            parttimeemployee.Lastname = "Doe";
            parttimeemployee.ShowFullName();
            Console.ReadLine();
        }
    }
}
