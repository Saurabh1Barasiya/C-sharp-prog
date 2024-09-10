using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_on_abstruct_class__or_property
{

    public abstract class Veichle
    {
        public string Model { get; set; }     // Regular property

        public abstract int Wheels { get;  }    // Abstract property   getter only.

        public Veichle(string model)
        {
            Model = model;
        }

        public void ShowModel()
        {
            Console.WriteLine($"Model name is {Model}");
        }
    }


    public class Car : Veichle
    {
        // calling base class constructor.
        public Car(string model) : base(model)
        {

        }

        // dono way se likh sakte h.
        //public override int Wheels { get => 4;  }

        public override int Wheels => 4;
    }

    public class Bike : Veichle
    {
        public Bike(string model) : base(model)
        { 
        
        }

        // overwrite the concept.
        public override int Wheels => 2;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Veichle car = new Car("Tesla mode 4");
            car.ShowModel();                      // Model name is Tesla mode 4
            Console.WriteLine(car.Wheels);   // 4


            Veichle bike = new Bike("Pulsor 220");
            bike.ShowModel();                    // Model name is Pulsor 220
            Console.WriteLine(bike.Wheels);      // 2

            Console.ReadLine();

        }
    }
}
