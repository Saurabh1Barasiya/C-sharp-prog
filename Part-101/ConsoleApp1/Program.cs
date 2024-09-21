using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // can we create object of abstruct class :-   NO
    // so why you create constructor here. object to ham bana hi nahi sakte h.


    // ham inheritace karte h to child class ka constructor parent class ke constructor ko call kar leta h.

    // to yaha ham child class ke constructor se parent class ke constructor ko call karwayege base keyword ka use karke.


    public abstract class Animal
    {
        public string Aname;
        public Animal(string name)
        {
            this.Aname = name;
            Console.WriteLine("Parent class Constructor is Called...");
        }

        public abstract void makesound();
    }

    public class Cat : Animal
    {
        // calling base classs  constructor.
        public Cat(string name) : base(name)
        {
            
        }

        public override void makesound()
        {
            Console.WriteLine($"Cat {this.Aname} is Saying mau mau");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("sohini");
            cat.makesound();
            Console.ReadLine();
        }
    }
}
