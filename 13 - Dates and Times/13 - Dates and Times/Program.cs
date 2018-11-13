using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Dates_and_Times
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            // Different ways to print dates and times

            //Console.Write(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-5).ToLongTimeString());

            //DateTime myBday = new DateTime(1992, 11, 8);
            //Console.WriteLine(myBday.ToShortDateString());

            DateTime myBday = DateTime.Parse("08-11-1992");
            //DateTime ShunBday = DateTime.Parse("09-01-1992");
            TimeSpan myAge = DateTime.Now.Subtract(myBday);
            Console.WriteLine(myAge.TotalDays);


            Console.ReadLine();

        }

    }

}
