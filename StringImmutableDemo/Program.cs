using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringImmutableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Elm, ";
            string temp1 = myString;
            Console.WriteLine("temp1=myString? {0}", Object.ReferenceEquals(myString, temp1));
            Console.ReadKey();

            myString += "Pine, ";
            Console.WriteLine("temp1=myString? {0}",Object.ReferenceEquals(myString, temp1));
            string temp2 = myString;
            Console.ReadKey();
            
            myString += "Redwood, ";
            string temp3 = myString;

            myString += "Sycamore. ";

            Console.WriteLine("myString: {0}", myString);
            Console.WriteLine("temp1: {0}", temp1);
            Console.WriteLine("temp2: {0}", temp2);
            Console.WriteLine("temp3: {0}", temp3);
            Console.ReadLine();
        }
    }
}
