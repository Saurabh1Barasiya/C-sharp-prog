using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setter_and_gtter
{

    public class Person
    {
        private string _name;
        private int _age;
        private string _address;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Saurabh";
            person.Age = 26;
            person.Address = "Harrai";

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address);

            Console.ReadLine();

            Console.WriteLine();
        }
    }
}
