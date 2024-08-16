using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Inheritance
{
    public class Human
    {
        public Human(string firstname, string lastname,string address, int age) {
            Console.WriteLine($"firstname {firstname}");
            Console.WriteLine($"lastname {lastname}");
            Console.WriteLine($"lastname {address}");
            Console.WriteLine($"age {age}");
        } 
    }

    public class Teacher : Human
    {
        public Teacher(string firstname,string lastname,int age,string address,string teachertype,double salary) : base(firstname,lastname,address,age)
        {
            Console.WriteLine($"Teacher type {teachertype}");
            Console.WriteLine($"Teacher salary {salary}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Saroj","nagwanshi",45,"Chhindwara","Primary",56000);
            Console.ReadLine();
        }
    }
}
