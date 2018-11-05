using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Please type your first name:");

            string FirstName = Console.ReadLine();

            /*
            string LastName;
            Console.Write("Now please type your last name:");
            LastName = Console.ReadLine();
            */

            Console.WriteLine("Now please type your last name:");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello, " + FirstName + " " + LastName + ".");
            Console.ReadLine();

        }
    }
}
