using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_overloding_more_concept
{

    // method overloding.
    public class Example
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
        
        public string Add(string a,string b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            Console.WriteLine(example.Add(1, 2));
            Console.WriteLine(example.Add(1.1f, 1.2f));
            Console.WriteLine(example.Add(100.123, 100.222));
            Console.WriteLine(example.Add("Saurabh ","Barasiya"));
            Console.ReadLine();
        }
    }
}
