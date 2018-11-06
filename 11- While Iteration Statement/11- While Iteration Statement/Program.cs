using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__While_Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool DisplayMenu = true;
            while (DisplayMenu == true)
            {
                DisplayMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose one option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");

            string Result = Console.ReadLine();

            if (Result == "1")
            {
                PrintNumbers();
                return true;
            }

            else if (Result == "2")
            {
                GuessingGame();
                return true;
            }

            else if (Result == "3")
            {
                return false;
            }

            else
            {
                return true;
            }


        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a number: ");
            int Result = int.Parse(Console.ReadLine());
            int Counter = 1;
            
            while (Counter < Result + 1)
	        {
                Console.Write(Counter);
                Console.Write("-");
                Counter++;
	        }

            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");

            Random MyRandom = new Random();
            int RandomNumber = MyRandom.Next(1,11);

            int Guesses = 0;
            bool Incorrect = true;

            // do while allows the user keep on guessing
            // when they haven't guessed correctly yet

            do
	        {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string Result =  Console.ReadLine();
                Guesses++;

                if (Result == RandomNumber.ToString())
	            {
                    Incorrect = false;
	            }

                else
	            {
                    Console.WriteLine("Wrong guess! Try again: ");
	            }

	        } while (Incorrect);
            Console.WriteLine("That is correct! It took you {0} guess(es).", Guesses);

            Console.ReadLine();
        }

    }
}
