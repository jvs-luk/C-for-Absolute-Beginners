using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found the seven!");
                    break;
                }
            }

            for (int MyValue = 0; MyValue < 12; MyValue++)
            {
                Console.WriteLine(MyValue);
            }


            Console.ReadLine();
        }
    }
}
