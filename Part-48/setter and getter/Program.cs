using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace setter_and_getter
{

    // In C#, setters and getters are part of properties, which are a way to encapsulate fields (variables) in a class and provide controlled access to them.
    // Setters are used to assign values to a field, while getters are used to retrieve values from a field.
    // Properties allow you to implement encapsulation by hiding the internal representation of a field and controlling how values are accessed or modified.
    

    // Getter: The get accessor is used to return the value of the private field.When you access the property, the getter is invoked.

    // Setter: The set accessor is used to assign a value to the private field.The value keyword represents the value being assigned.When you assign a value to the property, the setter is invoked.

    public class Person
    {
        private int _age;
        private string _name;

        public int Age {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(value)) { }
                else
                {
                    _name = value;
                }
            }
        }
    }


    public class Car
    {
        private int _carId = 123456;
        public int CarId
        {
            get
            {
                return _carId;
            }
        }


        private string _name;
        public string Name { 
            set
            {
                _name = value;
            }
        }


    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            Person person = new Person();

            // setting the data.
            person.Age = 20;
            person.Name = "Saurabh";

            // getting the data.
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);


            // car class.
            Car car = new Car();
            Console.WriteLine(car.CarId);
            car.Name = "Saurah";

            // ye only setter banaya h .
            // Console.WriteLine(car.Name);

            Console.ReadLine();
        }
    }
}
