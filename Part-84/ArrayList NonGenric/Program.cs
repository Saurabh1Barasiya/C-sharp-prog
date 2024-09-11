using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_NonGenric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ArrayList comes System.Collections namespace.
            // we can store multiple datatype value in Arraylist.
            // it can auometicallly grow.


            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);  // int
            arrayList.Add(2);  // int
            arrayList.Add("helllo");  // string
            arrayList.Add(10.5);   // double
            arrayList.Add('A');   // char



            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"The capacity of Arraylist {arrayList.Capacity}"); //  8
            //output :     1   2    helllo    10.5   A




            Console.WriteLine("-------------------------------------------");



            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(100);
            arrayList1.Add(200);
            arrayList1.Add(300);
            arrayList1.Add(400);

            // addind new list to previous arraylist.
            arrayList.AddRange(arrayList1);

            foreach (var item in arrayList)
            {
                Console.Write($"{item}  ");
            }

            // output : 1  2  helllo  10.5  A  100  200  300  400


            Console.WriteLine("");
            Console.WriteLine($"The capacity of Arraylist {arrayList.Capacity}"); //  16
            Console.WriteLine("-------------------------------------------");



            // 5th index se 4 value remove kar do.
            arrayList.RemoveRange(5, 4);
            foreach (var item in arrayList)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine("");
            Console.WriteLine($"The capacity of Arraylist {arrayList.Capacity}"); // 16

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(arrayList.Contains('A'));


            // ye only first occuremce hi remove karega.
            arrayList.Remove(1);

            foreach (var item in arrayList)
            {
                Console.Write($"{item}  ");
            }

            // 2  helllo  10.5  A



            // array list ko clear kar dega.
            arrayList.Clear();

            foreach (var item in arrayList)
            {
                Console.Write($"{item}  ");
            }

            // Array list is a Dynamic.

            Console.ReadLine();
        }
    }
}
