using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasicCalculator
{
    class Program
    {
        interface IBasicCalculator
        {
            void Addition();
            void Subtraction();
            void Multiplication();
            void Division();
        }

        class BasicCalculator:IBasicCalculator
        {
            string number1, number2;

            public void Addition()
            {
                Console.Write("Enter Your First Number:");
                number1 = Console.ReadLine();
                double x = Convert.ToDouble(number1);

                Console.Write("Enter Your First Number:");
                number2 = Console.ReadLine();
                double y = Convert.ToDouble(number2);

                double result = x + y;
                Console.WriteLine("Result:"+result);
                Console.WriteLine("    " );
            }
            public void Subtraction()
            {
                Console.Write("Enter Your First Number:");
                number1 = Console.ReadLine();
                double x = Convert.ToDouble(number1);

                Console.Write("Enter Your First Number:");
                number2 = Console.ReadLine();
                double y = Convert.ToDouble(number2);

                double result = x - y;
                Console.WriteLine("Result:" + result);
                Console.WriteLine("    ");
            }
            public void Multiplication()
            {
                Console.Write("Enter Your First Number:");
                number1 = Console.ReadLine();
                double x = Convert.ToDouble(number1);

                Console.Write("Enter Your First Number:");
                number2 = Console.ReadLine();
                double y = Convert.ToDouble(number2);

                double result = x * y;
                Console.WriteLine("Result:" + result);
                Console.WriteLine("    ");
            }
            public void Division()
            {
                Console.Write("Enter Your First Number:");
                number1 = Console.ReadLine();
                double x = Convert.ToDouble(number1);

                Console.Write("Enter Your First Number:");
                number2 = Console.ReadLine();
                double y = Convert.ToDouble(number2);

                if (y!=0)
                {
                    double result = x / y;
                    Console.WriteLine("Result:" + result);
                    Console.WriteLine("    ");
                }
                else
                {
                    Console.WriteLine("Invalid Result!");
                    Console.WriteLine("    ");
                }
            }
            
            
        }
        static void Main(string[] args)
        {
            IBasicCalculator ibc = new BasicCalculator();
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Enter Your Choice:");
                Console.WriteLine("1.Press '+' for Addition.");
                Console.WriteLine("2.Press '-' for Addition.");
                Console.WriteLine("3.Press '*' for Addition.");
                Console.WriteLine("4.Press '/' for Addition.");

                string choice;

                choice = Console.ReadLine();
                switch (choice)
                {

                    case "+":
                        ibc.Addition();
                        break;
                    case "-":
                        ibc.Subtraction();
                        break;
                    case "*":
                        ibc.Multiplication();
                        break;
                    case "/":
                        ibc.Division();
                        break;
                }
            }

        }
    }
}
