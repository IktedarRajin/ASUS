using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AccountHolder
    {
        protected int accountNumber;
        protected string name;
        protected string address;
        protected string dateOfBirth;
        public int startingBalance=0, amount=0,closingBalance;
        protected static int count = 1;
        protected static int transaction = 0;

        public AccountHolder()
        {
            
        }

        public void OpenAccount()
        {
            accountNumber = count;
            count++;
            Console.Write("Enter Your Name:");
            name = Console.ReadLine();
            Console.Write("Enter Your Address:");
            address = Console.ReadLine();
            Console.Write("Enter Your Date Of Birth:");
            dateOfBirth = Console.ReadLine();
            Console.Write("Enter Your Starting Balance");
            startingBalance = Convert.ToInt32(Console.ReadLine());
        }

        

        public void ShowDetails()
        {
            Console.WriteLine("Account Number:" + accountNumber + "\n"
                +"Name:" + name + "\n" + "Address:" + address + "\n"
                + "DoB:" + dateOfBirth + "\n" + "Starting Balance" 
                + startingBalance + "\n");
        }
    }
}
