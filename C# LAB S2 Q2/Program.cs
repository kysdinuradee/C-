using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB_S2_Q2
{
    class BankAccount
    {
        public int AccountNumber { get; private set; } // Account number cannot be changed after creation
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit successful. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter initial balance: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine());

            // Create a BankAccount object
            BankAccount account = new BankAccount(accountNumber, initialBalance);

            Console.Write("Enter amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            account.Deposit(depositAmount);
        }
    }
}
