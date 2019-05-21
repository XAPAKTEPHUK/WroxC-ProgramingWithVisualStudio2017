/* Ivan Boychuk
 * Chapter 5 - Complex Variable Types
 * String Manipulation */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = { ' '};
            string[] myWords;
            myWords = myString.Split(separator);//converts a string into a string array 
                                                //by splitting it at the points specified taken from char array
            foreach (string word in myWords)
            {
                WriteLine($"{word}");
            }
            ReadKey();
        }
    }
}
