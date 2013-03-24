using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder myStringBuilder = new StringBuilder("Elm, ");
            StringBuilder temp1 = myStringBuilder;

            myStringBuilder.Append("Pine, ");
            StringBuilder temp2 = myStringBuilder;

            myStringBuilder.Append("Redwood, ");
            StringBuilder temp3 = myStringBuilder;

            myStringBuilder.Append("Sycamore. ");

            Console.WriteLine("myString: {0}", myStringBuilder);
            Console.WriteLine("temp1: {0}", temp1.ToString());
            Console.WriteLine("temp2: {0}", temp2.ToString());
            Console.WriteLine("temp3: {0}", temp3.ToString());
            Console.ReadLine();
        }
    }
}
