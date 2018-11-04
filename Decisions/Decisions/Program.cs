using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jess' Big Giveaway");
            Console.Write("Pick door 1, 2 or 3: ");
            string UserDoor = Console.ReadLine();

            string message = "";

            if (UserDoor == "1")
                message = "You won a new car!";
            else if (UserDoor == "2") ;
                message = "You won a new boat!";
            else if (UserDoor == "3") ;
                message = "You won a new cat!";
            else
            {
                message = "Sorry, I do not understand your input";
                message = message + "You Lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}