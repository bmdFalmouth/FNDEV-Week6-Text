using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodePagesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // print header
            Console.Write("CodePage identifier and name     ");
            Console.WriteLine("1-Byte   ReadOnly ");

            // For every encoding, get the property values.
            foreach (EncodingInfo ei in Encoding.GetEncodings())
            {
                Encoding en = ei.GetEncoding();

                Console.Write("{0,-6} {1,-25} ", ei.CodePage, ei.Name);
                Console.WriteLine("{0,-8} {1,-8} ", en.IsSingleByte, en.IsReadOnly);
            }

            Console.ReadKey();
            Encoding e = Encoding.GetEncoding(1200); // UTF-16
            string inputString = "Hello World!";

            byte[] encoded = new byte[e.GetByteCount(inputString)];
            encoded = e.GetBytes(inputString);

            Console.Write("Initial String: {0}.{1}Encoded Bytes: ",
                inputString, Environment.NewLine);
            for (int i = 0; i < encoded.Length; i++)
            {
                Console.Write("{0} ", encoded[i]);
            }
            Console.WriteLine();

            e = Encoding.GetEncoding("windows-1252"); // Windows 1252
            inputString = "Hello World!";

            encoded = new byte[e.GetByteCount(inputString)];
            encoded = e.GetBytes(inputString);

            Console.Write("Initial String: {0}.{1}Encoded Bytes: ",
                inputString, Environment.NewLine);
            for (int i = 0; i < encoded.Length; i++)
            {
                Console.Write("{0} ", encoded[i]);
            }
            Console.WriteLine();



        }
    }
}
