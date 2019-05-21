/* Ivan Boychuk
 * Chapter 5 - Complex Variable Types
 * Using an Array */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle", null, "" };
            foreach (var friendName in friendNames)
            {
                switch (friendName)
                {
                    case string t when t.StartsWith("T"):
                        WriteLine("This friends name starts with 'T': " +
                                $"{friendName} and is {t.Length -1} letters long.");
                        break;
                    case string e when e.Length == 0: //checks for an empty string
                        WriteLine("There is a string in an array that has no value.");
                        break;
                    case null:
                        WriteLine("THere was a 'null' value in an array");
                        break;
                    case var x: //Patter Matching, where order of cases matters
                        WriteLine("This is the var pattern of type : " +
                            $"{x.GetType().Name}");
                        break;
                    default:
                        break;
                }
            }
            int sum = 0, total = 0, counter = 0, intValue = 0;
            int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 }; //? lets array store null objects
            foreach (var integer in myIntArray)
            {
                switch(integer)
                {
                    case 0:
                        WriteLine($"Integer number '{ total }' has default value of 0");
                        counter++;
                        break;
                    case int value:
                        sum += value;
                        WriteLine($"Integer number '{ total }' has a value of {value}");
                        counter++;
                        break;
                    case null:
                        WriteLine($"Integer number '{ total }' is null");
                        counter++;
                        break;
                    default:
                        break;
                }
            }
            WriteLine($"{total} total integers, {counter} integers with a " +
                $"value other than 0 or null have a sum value of {sum}");
            ReadLine();
        }
    }
}
