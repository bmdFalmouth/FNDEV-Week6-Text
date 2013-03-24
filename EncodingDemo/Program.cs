using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncodingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding e = Encoding.BigEndianUnicode;  // change to show other encodings
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

        }
    }
}
