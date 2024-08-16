using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class
{
    static class Example
    {
        public static double Productprice;
        public static string ProductName;
        public static double Productdiscount;

        static Example()
        {
            ProductName = "Samsung Mobile";
            Productprice = 26000.00;
            Productdiscount = 0;
        }

        public static void getDiscount(int discount)
        {
            Console.WriteLine($"------------ Giving discount -----------------{ProductName}");
            Productdiscount = (Productprice * discount)/100;
            double TotelBil = Productprice - Productdiscount;

            Console.WriteLine($"Product discount is : { Productdiscount }");
            Console.WriteLine($"Totel bil is : {TotelBil}");
        }

        public static void ShowData()
        {
            Console.WriteLine($"ProductName : {ProductName}");
            Console.WriteLine($"Productprice : {Productprice}");
        }
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example.ShowData();
            Example.getDiscount(5);
            Console.ReadLine();
        }
    }
}
