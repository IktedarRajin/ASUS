using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Student
    {
        private string name;
        private string[] phoneNumber= new string[2];
        private string[] hobbies = new string[5];

        public string this[int index]
        {
            set { phoneNumber[index] = value; }
            get { return phoneNumber[index]; }
        }

        public string this[uint index]
        {
            set { hobbies[index] = value; }
            get { return hobbies[index]; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Student s = new Student();
            s[0] = "017*********";
            s[1] = "018*********";


            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
        }
    }
}
