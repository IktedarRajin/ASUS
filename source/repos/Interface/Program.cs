using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        interface Creature
        {
            void Hands();
            void Legs();
            
        }

        interface Operation
        {
            void Walk();

            void Run();
        }

        class Human : Creature, Operation
        {
            public Human()
            {
                Console.WriteLine("This is Human!");
            }
            public void Hands()
            {
                Console.WriteLine("It has 2 hands!");
            }
            public void Legs()
            {
                Console.WriteLine("It has 2 Legs!");
            }

            public void Walk()
            {
                Console.WriteLine("It Can Walk");
            }

            public void Run()
            {
                Console.WriteLine("It Can Run");
            }
        }

        static void Main(string[] args)
        {
            /*Creature c;
            c = new Human();
            c.Hands();
            c.Legs();*/

            Creature c;
            c = new Human();
            c.Hands();
            c.Legs();
            ((Operation)c).Run(); /*implementing different interface members
                                        using down casting.*/
            ((Operation)c).Walk();

        }
    }
}
