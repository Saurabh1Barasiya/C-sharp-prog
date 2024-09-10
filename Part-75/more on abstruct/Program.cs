using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_abstruct
{
    public abstract class Vehicle
    {
        public string Make {  get; set; }
        public string Model {  get; set; }

        // abstruct method.

        public abstract void StartEngine();
        
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car is Started...");
        }
    }

    public class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike is Started...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.StartEngine(); //  Bike is Started...

            Car car = new Car();    
            car.StartEngine(); //  Car is Started...

            Console.WriteLine("---------------------------------------------------");

            // Aese bhi karte h 
            // hame pata h ki parent class ka variable child class ka object store kar sakta h.

            Vehicle vehicle = new Car();    
            vehicle.StartEngine();  // Car is Started...

            Vehicle vehicle1 = new Bike();
            vehicle1.StartEngine();  // Bike is Started...

            Console.ReadLine();
        }
    }
}
