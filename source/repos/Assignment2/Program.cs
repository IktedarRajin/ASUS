using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account account = new Account();
            Console.WriteLine("Enter 'Open' To open an account.\n" +
                "Enter 'Account' to Perform transactions on an account.\n" +
                "Enter 'Quit' to Exit the application.");
            string actions= Console.ReadLine();

            switch (actions)
            {
                case "Open":
                    Console.WriteLine("Enter 'Savings' to Open a savings account\n" +
                        "Enter 'Checking' to Open a checking account");
                    string choice1 = Console.ReadLine();
                    switch(choice1)
                    {
                        case "Savings":
                            account.OpenAccount();
                            account.ShowDetails();

                            break;
                        case "Checking":
                            account.OpenAccount();
                            account.ShowDetails();
                            break;
                        case "Quit":
                            
                            break;
                    }
                    break;
               
                case "Account":
                    Console.WriteLine("Enter 'Diposit' to Open a savings account\n" +
                        "Enter 'Withdraw' to Make a withdrawal\n" +
                        "Enter 'Transfer' to Make a transfer\n" +
                        "Enter 'Change' to Change owner name\n" +
                        "Enter 'Show' to Show the number transactions\n" +
                        "Enter 'Quit' to Exit the application");
                    string choice2 = Console.ReadLine();
                    switch (choice2)
                    {
                        case "Diposit":
                            account.Deposit();
                            account.ShowDetails();
                            break;
                        case "Withdraw":
                            account.Withdraw();
                            account.ShowDetails();
                            break;
                        case "Transfer":
                            account.Transfer();
                            account.ShowDetails();
                            break;
                        case "Change":
                            account.ChangeName();
                            account.ShowDetails();
                            break;
                        case "Show":
                            account.ShowNumberOfTransaction();
                            account.ShowDetails();
                            break;
                        case "Quit":
                            
                            break;
                    }

                    break;
                case "Quit":
                    
                    break;
            }
        }
    }
}
