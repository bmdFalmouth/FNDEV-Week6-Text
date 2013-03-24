using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a regular expression for currency values.
            Regex rx = new Regex(@"^-?\d+(\.\d{2})?$");

            // Define some test strings.
            string[] tests = {"-42", "19.99", "0.001", "100 USD", 
                           ".34", "0.34", "1,052.21"};

            // Check each test string against the regular expression.
            foreach (string test in tests)
            {
                if (rx.IsMatch(test))
                {
                    Console.WriteLine("{0} is a currency value.", test);
                }
                else
                {
                    Console.WriteLine("{0} is not a currency value.", test);
                }
            }

            // Define a regular expression for repeated words.
            rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",         // \k references a capture group inside the regex
              RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Define a test string.        
            string text = "The the quick brown fox  fox jumped over the lazy dog dog.";

            // Find matches.
            MatchCollection matches = rx.Matches(text);

            // Report the number of matches found.
            Console.WriteLine("{0} matches found in:\n   {1}",
                              matches.Count,
                              text);

            // Report on each match.
            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                                  groups["word"].Value,
                                  groups[0].Index,
                                  groups[1].Index);
            }

            Console.ReadLine();
        }

    }
}
