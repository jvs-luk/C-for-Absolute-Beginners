using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string MyString = "My \"so-called\" life";
            //string MyString = "What if I need a \nnew line?"
;
            //string MyString = "Go to your C:\\ drive";
            //string MyString = @"Go to your C:\ drive";

            //string MyString = String.Format("{1} = {0}", "First", "Second");

            // Following displays string data as currency
            //string MyString = string.Format("{0:C}", 123.45);

            // Following displays correct format for big numbers
            //string MyString = string.Format("{0:N}",1234567890);

            // Following displays string as percentage
            //string MyString = string.Format("{0:P}", .123);

            //string MyString = string.Format("Phone Number: {0:(###)###-####}",1234567890);
            
            //string MyString = " All the weight of our dreams ";
            
            //MyString = MyString.Substring(6,14);
            //MyString = MyString.ToUpper();
            //MyString = MyString.Replace(" ", "--");
            //MyString = MyString.Remove(6,14);

            /*
            MyString = String.Format("Length before: {0} -- Length after: {1}",
                MyString.Length,
                MyString.Trim().Length);
            */

            string MyString = "";

            for (int i = 0; i < 100; i++)
			{
                MyString += "--" + i.ToString();
			}

            Console.WriteLine(MyString);
            Console.ReadLine();

        }


    }


}
