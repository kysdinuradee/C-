using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_C__06
{
    internal class Program
    {
        class ATM
        {
            static int balance = 1000; // Initial balance

            static void Main(string[] args)
            {
                int choice;

                do
                {
                    Console.WriteLine("\nATM Menu:");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CheckBalance();
                            break;
                        case 2:
                            Deposit();
                            break;
                        case 3:
                            Withdraw();
                            break;
                        case 4:
                            Console.WriteLine("Exiting ATM...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                } while (choice != 4);
            }

            static void CheckBalance()
            {
                Console.WriteLine("\nYour current balance is: ${0}", balance);
            }

            static void Deposit()
            {
                int amount;

                Console.Write("\nEnter amount to deposit: ");
                amount = Convert.ToInt32(Console.ReadLine());

                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine("Deposit successful. New balance: ${0}", balance);
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
                }
            }

            static void Withdraw()
            {
                int amount;

                Console.Write("\nEnter amount to withdraw: ");
                amount = Convert.ToInt32(Console.ReadLine());

                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal successful. Please collect your cash. New balance: ${0}", balance);
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient funds. Your current balance is: ${0}", balance);
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
                }
            }
        }
    }
}
