/* Ivan Boychuk
 * Chapter 6 - Functions
 * Command-Line Arguments*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex04CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"{args.Length} command line arguments were specified: ");
            foreach (string arg in args)
                WriteLine(arg);
            ReadKey();
        }
    }
}
