using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Four Numbers \n");

            int numberOne, numberTwo, numberThree, numberFour;
            Console.WriteLine("Give me a number: ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a second number: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a third number :");
            numberThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a last number: ");
            numberFour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of your four numbers is " + $"{numberOne + numberTwo + numberThree + numberFour}");
            Console.ReadKey();

        }
    }
}
