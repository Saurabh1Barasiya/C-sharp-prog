using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptation_practical
{
    public class BankAccount
    {
        private decimal balance; // Private field

        // Public property with setter and getter, making it read-only
        public decimal Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                balance = amount;
            }
        }

        // Method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance in your account...");
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();

            // hamne private variable ko access nahi kiya, jabki uske liye getter and setter banaya h.
            obj.Balance = 5000;

            Console.WriteLine($"Current balence is {obj.Balance}");
            obj.Deposit(5000);
            Console.WriteLine($"Current balence is {obj.Balance}");
            obj.Withdraw(2000);
            Console.WriteLine($"Current balence is {obj.Balance}");
            Console.ReadLine();
        }
    }
}
