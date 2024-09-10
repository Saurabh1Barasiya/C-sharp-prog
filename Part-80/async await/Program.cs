using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    internal class Program
    {
        public static async Task  GetDataAsync()
        {
            Console.WriteLine("Starting task 1...");
            await Task.Delay(2000);  // Simulate task 1
            Console.WriteLine("Task 1 completed.");

            Console.WriteLine("Starting task 2...");
            await Task.Delay(1000);  // Simulate task 2
            Console.WriteLine("Task 2 completed.");
        }

        static void Main(string[] args)
        {
            GetDataAsync();
            Console.ReadLine();
        }
    }
}
