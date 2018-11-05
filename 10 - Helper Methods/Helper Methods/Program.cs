using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            // We continue to make the code as short and
            // efficient as possible with methods

            
            Console.Write("What's your first name?");
            string FirstName = Console.ReadLine();

            Console.Write("What's your last name?");
            string LastName = Console.ReadLine();

            Console.Write("What city were you born in?");
            string City = Console.ReadLine();

            // Following is the simplest, but most repetitive
            // method of printing reverse user input

            /*
            char[] FirstNameArray = FirstName.ToCharArray();
            Array.Reverse(FirstNameArray);

            char[] LastNameArray = LastName.ToCharArray();
            Array.Reverse(LastNameArray);

            char[] CityArray = City.ToCharArray();
            Array.Reverse(CityArray);

            string Result = "";

            foreach (char item in FirstNameArray)
            {
                Result += item;
            }

            Result += " ";

            foreach (char item in LastNameArray)
            {
                Result += item;
            }

            Result += " ";

            foreach (char item in CityArray)
            {
                Result += item;
            }

            Console.WriteLine("Results:" + Result);
            */

            // Prints out the given strings in reverse
            // Obsolete since addition of lines 86-89

            /*
            Console.Write("Results: ");
            string ReversedFirstName = ReverseString(FirstName);
            string ReversedLastName = ReverseString(LastName);
            string ReversedCity = ReverseString(City);
            */

            // Possible, but inefficient:
            // Console.WriteLine(ReversedFirstName + " " 
            // + ReversedLastName + " "
            // + ReversedCity);

            // Reversed... on seperate lines for readability

            // Following has been turned into own method 
            // in lines 123-128

            /*
            Console.Write(String.Format("{0} {1} {2}", 
                ReversedFirstName, 
                ReversedLastName, 
                ReversedCity ));
            */

            DisplayResult(
                ReverseString(FirstName),
                ReverseString(LastName),
                ReverseString(City));

            Console.ReadLine();
        }

        // Following method was the first, but not most 
        // efficient method

        /*
        private static void ReverseString(string Message)
        {
            // Now the user input is stored in string Message,
            // meaning no more need for a seperate
            // initialisation string Message = "Hello World";

            // Method takes strings and prints them out in
            // reverse
            
            char[] MessageArray = Message.ToCharArray();
            Array.Reverse(MessageArray);

            foreach (char item in MessageArray)
            {
                Console.Write(item);
            }

            Console.Write(" ");

        }
        */

        // Rule of thumb; no more than 6 lines in your
        // methods 
        
        // More efficient method using Concat, changed
        // call function in 65-67 to string values

        private static string ReverseString(string Message)
        {
            char[] MessageArray = Message.ToCharArray();
            Array.Reverse(MessageArray);
            return String.Concat(MessageArray);
        }

        // Strings on seperate lines for readability

        private static void DisplayResult(
            string ReversedFirstName, 
            string ReversedLastName, 
            string ReversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}",
                ReversedFirstName,
                ReversedLastName,
                ReversedCity));
        }
    }
}
