using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] Numbers = new int[5];
            Numbers[0] = 4;
            Numbers[1] = 8;
            Numbers[2] = 15;
            Numbers[3] = 16;
            Numbers[4] = 23;

            Console.WriteLine(Numbers[1]);
            Console.WriteLine(Numbers.Length);
            Console.ReadLine();
            */

            // int[] Numbers = new int[] { 4, 8, 15, 16, 23, 42 }; 

            //string[] Names = new string[] { "Emil", "Nier", "Kaine", "Yonah" };

            /*
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine(Names[i]);
            }
            Console.ReadLine();
            */

            /*
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string Nier = "We need a god worth dying for.";

            char[] CharArray = Nier.ToCharArray();
            Array.Reverse(CharArray);

            foreach (char NierChar in CharArray)
            {
                Console.Write(NierChar);
            }
            Console.ReadLine();
        }
    }
}
