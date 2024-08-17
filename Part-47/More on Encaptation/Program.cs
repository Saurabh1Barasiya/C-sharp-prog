using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_on_Encaptation
{
    class Person
    {
        private string name;
        private int age;

        public int Age { 
            get
            {
                return age;
            }
            set {
                age = value;
            }
        }
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void showData()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Encaptation me ham data ko private banate h.

            // Fir us data ko direct access karke ke liye setter and getter banate h.

            // is process ko data hiding kahte h.


            // agar app name and age ko access karna cahte h to app getter and setter ka use karege .
            // because name and age private h.

            Person person = new Person();

            person.Name = "Saurabh";
            person.Age = 20;

            person.showData();

            Console.ReadLine();
        }
    }
}
