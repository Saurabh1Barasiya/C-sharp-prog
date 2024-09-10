using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric_class
{
    // In C#, generic classes allow you to define classes that can work with any data type. 
    // A generic class is a class that can work with any data type specified at the time of object creation.
    // You define a generic class by using type parameters(usually represented by<T>), where T is a placeholder for the actual data type.

    public class GenricClass<T>
    {
        private T data;

        public GenricClass(T value) {
            data = value;
        }

        // method to return T value.

        public T GetData()
        {
            return data;
        }

        public void SetData(T value) { 
            data = value;
        }

        public void ShowData()
        {
            Console.WriteLine($"Data is {data}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            // T is a generic type parameter. You can replace T with any data type(like int, string, etc.) when you create an instance of this class.

            GenricClass<int> obj = new GenricClass<int>(10);
            obj.ShowData();

            obj.SetData(50);
            obj.ShowData();


            Console.WriteLine("-------------------------------------");

            GenricClass<string> obj1 = new GenricClass<string>("saurabh");
            obj1.ShowData();

            obj1.SetData("Saurabh Barasiya");
            obj1.ShowData();


            Console.ReadKey();
        }
    }
}
