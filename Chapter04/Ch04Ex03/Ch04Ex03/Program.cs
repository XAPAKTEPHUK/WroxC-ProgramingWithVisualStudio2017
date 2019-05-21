/* Ivan Boychuk
 * Chapter 4 - Flow Control
 * Using the switch Statement */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "ivan";
            const string niceName = "veronika";
            const string sillyName = "chicken";
            string name;
            WriteLine("What is your name?");
            name = ReadLine();
            switch (name.ToLower()) //Convert.ToLover() forces user input to lowercase 
            {
                case myName:
                    WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    WriteLine("My, that's a nice name you have!");
                    break;
                case sillyName:
                    WriteLine("That's a silly name");
                    break;   
            }
            WriteLine($"Hello {name}");
            ReadKey();

        }
    }
}
