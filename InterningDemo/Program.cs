using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InterningDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two different string objects with same value
            // (don't use literals for this demo as these are usually interned by default)
            String s1 = String.Format("{0}", "Hello");
            String s2 = String.Format("{0}", "Hello");
            Console.WriteLine(Object.ReferenceEquals(s1, s2));    // different strings with same value

            // intern these strings
            s1 = String.Intern(s1);
            s2 = String.Intern(s2);
            Console.WriteLine(Object.ReferenceEquals(s1, s2));    // now have two references to the same string
        
            // count number of times a word appears in a wordlist
            string myWord = "red";
            // literal strings may be interned by default, but do it explicitly to be sure
            string[] myWords = { String.Intern("green"),
                                   String.Intern("red"), 
                                   String.Intern("blue"), 
                                   String.Intern("red"), 
                                   String.Intern("red"), 
                                   String.Intern("blue"), 
                                   String.Intern("green") };
            
            Console.WriteLine("Using Equals: {0}", NumTimesWordAppearsEquals(myWord, myWords));
            Console.WriteLine("Using Intern: {0}", NumTimesWordAppearsIntern(myWord, myWords));
        }

        static int NumTimesWordAppearsEquals(string word, string[] wordlist)
        {
            int count = 0;
            for (int wordnum = 0; wordnum < wordlist.Length; wordnum++)
            {
                if (word.Equals(wordlist[wordnum], StringComparison.Ordinal))
                {
                    count++;
                }
            }
            return count;
        }

        static int NumTimesWordAppearsIntern(string word, string[] wordlist)
        {
            // method assumes that all entries in wordlist have been interned
            word = String.Intern(word);
            int count = 0;
            for (int wordnum = 0; wordnum < wordlist.Length; wordnum++)
            {
                if (object.ReferenceEquals(word,wordlist[wordnum]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
