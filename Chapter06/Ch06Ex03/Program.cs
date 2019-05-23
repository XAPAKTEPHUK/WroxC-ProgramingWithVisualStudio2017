/* Ivan Boychuk
 * Chapter 6 - Functions
 * Exchanging Data with Functions*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex03
{
    class Program
    {
        static int SumVals(params int[] vals)//parameter array - defined using 'params', only one per function is allowed
        {
            int sum = 0;
            foreach(int val in vals)
            {
                sum += val;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = SumVals(1, 5, 2, 9, 8);
            WriteLine($"Summed values = {sum}");
            ReadKey();
        }
    }
}
