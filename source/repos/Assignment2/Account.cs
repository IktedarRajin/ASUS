using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Account:AccountHolder
    {
        AccountHolder[] accountHolders;

        public Account()
        {
            this.accountHolders = new Account[count];
        }

        public void Deposit()
        {
            Console.WriteLine("Enter Your Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            closingBalance = startingBalance - amount;

            Console.WriteLine("New Balance=" + closingBalance);
            transaction++;
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter Your Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            closingBalance = startingBalance - amount;

            Console.WriteLine("New Balance=" + closingBalance);
            transaction++;
        }

        public void Transfer()
        {
            int accountNo;

            Console.WriteLine("Enter Desired Amount:");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Desired Account Number:");
            accountNo = Convert.ToInt32(Console.ReadLine());

            if (amount<0 && accountNo != 0)
            {
                for (int i = 0; i <= accountHolders.Length;i++)
                { 
                    if(i==accountNo)
                    {
                        closingBalance = startingBalance - amount;
                        accountHolders[i].closingBalance = startingBalance - amount; ;

                        break;

                    }
                }
            }
            transaction++;
        }

        public void ChangeName()
        {
            Console.Write("Enter New Name:");
            name = Console.ReadLine();
            Console.Write("Name Changed To:" + name);
            
        }

        public void ShowNumberOfTransaction()
        {
            Console.WriteLine("Number of Transaction:" +transaction);
        }

        public void ClosingBalance()
        {
            Console.WriteLine("Closing Balance:" +closingBalance);
        }



    }
}
