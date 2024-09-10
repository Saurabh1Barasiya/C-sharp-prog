using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_await
{
    internal class Program
    {

        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 1 starting ...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 1 completed ...");
            });

            // jab async task chal jayega tab hi ye line chalegi.
            Console.WriteLine("---------------------------------");
        }

        public static async void Task2()
        {

            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 starting ...");
                Thread.Sleep(3000);
                Console.WriteLine("Task 2 completed ...");
            });
            Console.WriteLine("---------------------------------");
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadLine();
        }
    }
}
