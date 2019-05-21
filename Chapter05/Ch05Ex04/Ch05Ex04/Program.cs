/* Ivan Boychuk
 * Chapter 5 - Complex Variable Types
 * Using an Array */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            int i;
            Console.WriteLine($"Here are {friendNames.Length} of my friends:"); //.Length returns the number of elements in an array
            for (i=0; i<friendNames.Length;i++)
            {
                Console.WriteLine(friendNames[i]);
            }
            Console.ReadKey();
        }
    }
}
