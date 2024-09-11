using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace List_of_employees
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }

        public Employee(int id,string name,double sal,string address)
        {
            EmployeeId = id;
            Name = name;
            Salary = sal;
            Address = address;
        }

        public void show()
        {
            Console.WriteLine($"Employee Id {EmployeeId}");
            Console.WriteLine($"Employee name {Name}");
            Console.WriteLine($"Employee Salary {Salary}");
            Console.WriteLine($"Employee Address {Address}");
            Console.WriteLine("-----------------------------------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(100, "saurabh", 50000, "Chhindwara"));
            list.Add(new Employee(200, "Peeyush", 50000, "Chhindwara"));
            list.Add(new Employee(300, "aman", 50000, "Chhindwara"));
            list.Add(new Employee(400, "jhon", 50000, "US"));

            Employee e = new Employee(232, "Malisa", 50000, "US");
            list.Add(e);

            foreach (Employee emp in list)
            {
                emp.show();
            }

            Console.ReadLine(); 
        }
    }
}
