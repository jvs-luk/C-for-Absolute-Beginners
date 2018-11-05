using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.ReadLine();
        }
            
        // Most simple method example
        // NOTE how it's outside of void Main

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

    }
}
